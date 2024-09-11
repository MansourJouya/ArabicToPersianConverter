

using System;
using System.Collections.Generic;
using System.Text;

namespace ArabicToPersianConverter
{
    /// <summary>
    /// Provides methods for converting Arabic script characters to Persian script characters.
    /// </summary>
    public static class Normalizer
    {
        /// <summary>
        /// A dictionary mapping Arabic script characters (by their Unicode code points) to Persian script characters.
        /// </summary>
        private static readonly Dictionary<int, string> ArabicToPersianMap = new()
        {
            // Arabic character 'ک' (Unicode 64400-64414) maps to Persian 'ک'
            { 64400, "ک" }, { 64401, "ک" }, { 64402, "گ" }, { 64403, "گ" },
            { 64404, "گ" }, { 64405, "گ" }, { 64406, "گ" }, { 64407, "گ" },
            { 64408, "گ" }, { 64409, "گ" }, { 64410, "گ" }, { 64411, "گ" },
            { 64412, "گ" }, { 64413, "گ" }, { 64414, "گ" },

            // Arabic character 'ا' (Unicode 65165-65166) maps to Persian 'ا'
            { 65165, "ا" }, { 65166, "ا" },

            // Arabic character 'ب' (Unicode 65167-65170) maps to Persian 'ب'
            { 65167, "ب" }, { 65168, "ب" }, { 65169, "ب" }, { 65170, "ب" },

            // Arabic character 'ت' (Unicode 65171-65176) maps to Persian 'ت'
            { 65171, "ت" }, { 65172, "ت" }, { 65173, "ت" }, { 65174, "ت" },
            { 65175, "ت" }, { 65176, "ت" },

            // Arabic character 'ث' (Unicode 65177-65180) maps to Persian 'ث'
            { 65177, "ث" }, { 65178, "ث" }, { 65179, "ث" }, { 65180, "ث" },

            // Arabic character 'ج' (Unicode 65181-65184) maps to Persian 'ج'
            { 65181, "ج" }, { 65182, "ج" }, { 65183, "ج" }, { 65184, "ج" },

            // Arabic character 'ح' (Unicode 65185-65188) maps to Persian 'ح'
            { 65185, "ح" }, { 65186, "ح" }, { 65187, "ح" }, { 65188, "ح" },

            // Arabic character 'خ' (Unicode 65189-65192) maps to Persian 'خ'
            { 65189, "خ" }, { 65190, "خ" }, { 65191, "خ" }, { 65192, "خ" },

            // Arabic character 'د' (Unicode 65193-65194) maps to Persian 'د'
            { 65193, "د" }, { 65194, "د" },

            // Arabic character 'ذ' (Unicode 65195-65196) maps to Persian 'ذ'
            { 65195, "ذ" }, { 65196, "ذ" },

            // Arabic character 'ر' (Unicode 65197-65198) maps to Persian 'ر'
            { 65197, "ر" }, { 65198, "ر" },

            // Arabic character 'ز' (Unicode 65199-65200) maps to Persian 'ز'
            { 65199, "ز" }, { 65200, "ز" },

            // Arabic character 'س' (Unicode 65201-65204) maps to Persian 'س'
            { 65201, "س" }, { 65202, "س" }, { 65203, "س" }, { 65204, "س" },

            // Arabic character 'ش' (Unicode 65205-65208) maps to Persian 'ش'
            { 65205, "ش" }, { 65206, "ش" }, { 65207, "ش" }, { 65208, "ش" },

            // Arabic character 'ص' (Unicode 65209-65212) maps to Persian 'ص'
            { 65209, "ص" }, { 65210, "ص" }, { 65211, "ص" }, { 65212, "ص" },

            // Arabic character 'ض' (Unicode 65213-65216) maps to Persian 'ض'
            { 65213, "ض" }, { 65214, "ض" }, { 65215, "ض" }, { 65216, "ض" },

            // Arabic character 'ط' (Unicode 65217-65220) maps to Persian 'ط'
            { 65217, "ط" }, { 65218, "ط" }, { 65219, "ط" }, { 65220, "ط" },

            // Arabic character 'ظ' (Unicode 65221-65224) maps to Persian 'ظ'
            { 65221, "ظ" }, { 65222, "ظ" }, { 65223, "ظ" }, { 65224, "ظ" },

            // Arabic character 'ع' (Unicode 65225-65228) maps to Persian 'ع'
            { 65225, "ع" }, { 65226, "ع" }, { 65227, "ع" }, { 65228, "ع" },

            // Arabic character 'غ' (Unicode 65229-65232) maps to Persian 'غ'
            { 65229, "غ" }, { 65230, "غ" }, { 65231, "غ" }, { 65232, "غ" },

            // Arabic character 'ف' (Unicode 65233-65236) maps to Persian 'ف'
            { 65233, "ف" }, { 65234, "ف" }, { 65235, "ف" }, { 65236, "ف" },

            // Arabic character 'ق' (Unicode 65237-65240) maps to Persian 'ق'
            { 65237, "ق" }, { 65238, "ق" }, { 65239, "ق" }, { 65240, "ق" },

            // Arabic character 'ک' (Unicode 65241-65244) maps to Persian 'ک'
            { 65241, "ک" }, { 65242, "ک" }, { 65243, "ک" }, { 65244, "ک" },

            // Arabic character 'ل' (Unicode 65245-65248) maps to Persian 'ل'
            { 65245, "ل" }, { 65246, "ل" }, { 65247, "ل" }, { 65248, "ل" },

            // Arabic character 'م' (Unicode 65249-65252) maps to Persian 'م'
            { 65249, "م" }, { 65250, "م" }, { 65251, "م" }, { 65252, "م" },

            // Arabic character 'ن' (Unicode 65253-65256) maps to Persian 'ن'
            { 65253, "ن" }, { 65254, "ن" }, { 65255, "ن" }, { 65256, "ن" },

            // Arabic character 'ه' (Unicode 65257-65260) maps to Persian 'ه'
            { 65257, "ه" }, { 65258, "ه" }, { 65259, "ه" }, { 65260, "ه" },

            // Arabic character 'و' (Unicode 65261-65262) maps to Persian 'و'
            { 65261, "و" }, { 65262, "و" },

            // Arabic character 'ی' (Unicode 65263-65268) maps to Persian 'ی'
            { 65263, "ی" }, { 65264, "ی" }, { 65265, "ی" }, { 65266, "ی" },
            { 65267, "ی" }, { 65268, "ی" },

            // Arabic character 'لا' (Unicode 65269-65276) maps to Persian 'لا'
            { 65269, "لا" }, { 65270, "لا" }, { 65271, "لا" }, { 65272, "لا" },
            { 65273, "لا" }, { 65274, "لا" }, { 65275, "لا" }, { 65276, "لا" },

            // Arabic character 'ک' and 'و' mappings (Unicode 64467-64484)
            { 64467, "ک" }, { 64468, "ک" }, { 64469, "ک" }, { 64470, "ک" },
            { 64471, "و" }, { 64472, "و" }, { 64473, "و" }, { 64474, "و" },
            { 64475, "و" }, { 64476, "و" }, { 64477, "و" }, { 64478, "و" },
            { 64479, "و" }, { 64480, "و" }, { 64481, "و" }, { 64482, "و" },
            { 64483, "ی" }, { 64484, "ی" }, { 64485, "ی" }, { 64486, "ی" },

            // Arabic character 'ا' (Unicode 64487-64511) maps to Persian 'ا' and 'ی'
            { 64487, "ا" }, { 64488, "ا" }, { 64489, "ا" }, { 64490, "ا" },
            { 64491, "ا" }, { 64492, "ا" }, { 64493, "ا" }, { 64494, "و" },
            { 64495, "و" }, { 64496, "و" }, { 64497, "و" }, { 64498, "و" },
            { 64499, "و" }, { 64500, "و" }, { 64501, "و" }, { 64502, "ی" },
            { 64503, "ی" }, { 64504, "ی" }, { 64505, "ی" }, { 64506, "ی" },
            { 64507, "ی" }, { 64508, "ی" }, { 64509, "ی" }, { 64510, "ی" },
            { 64511, "ی" },

            // Arabic character 'ا' and 'ی' mappings (Unicode 64336-64399)
            { 64336, "ا" }, { 64337, "ا" }, { 64338, "ی" }, { 64339, "ی" },
            { 64340, "ی" }, { 64341, "ی" }, { 64342, "پ" }, { 64343, "پ" },
            { 64344, "پ" }, { 64345, "پ" }, { 64346, "پ" }, { 64347, "پ" },
            { 64348, "پ" }, { 64349, "پ" }, { 64350, "ت" }, { 64351, "ت" },
            { 64352, "ت" }, { 64353, "ت" }, { 64354, "ت" }, { 64355, "ت" },
            { 64356, "ت" }, { 64357, "ت" }, { 64358, "ط" }, { 64359, "ط" },
            { 64360, "ط" }, { 64361, "ط" }, { 64362, "و" }, { 64363, "و" },
            { 64364, "و" }, { 64365, "و" }, { 64366, "و" }, { 64367, "و" },
            { 64368, "و" }, { 64369, "و" }, { 64370, "چ" }, { 64371, "چ" },
            { 64372, "چ" }, { 64373, "چ" }, { 64374, "چ" }, { 64375, "چ" },
            { 64376, "چ" }, { 64377, "چ" }, { 64378, "چ" }, { 64379, "چ" },
            { 64380, "چ" }, { 64381, "چ" }, { 64382, "چ" }, { 64383, "چ" },
            { 64384, "چ" }, { 64385, "چ" }, { 64386, "د" }, { 64387, "د" },
            { 64388, "د" }, { 64389, "د" }, { 64390, "د" }, { 64391, "د" },
            { 64392, "د" }, { 64393, "د" }, { 64394, "ژ" }, { 64395, "ژ" },
            { 64396, "ر" }, { 64397, "ر" }, { 64398, "ک" }, { 64399, "ک" }
        };

        /// <summary>
        /// Converts a string containing Arabic script characters to Persian script characters.
        /// </summary>
        /// <param name="text">The input string containing Arabic characters.</param>
        /// <returns>The converted string with Persian characters.</returns>
        public static string ConvertArabicToPersian(string text)
        {
            var stringBuilder = new StringBuilder();

            foreach (char c in text)
            {
                // Convert each character using the ArabicToPersianMap
                if (ArabicToPersianMap.TryGetValue(c, out var persianLetter))
                {
                    stringBuilder.Append(persianLetter);
                }
                else
                {
                    stringBuilder.Append(c); // Keep character as is if not found in the map
                }
            }

            return stringBuilder.ToString();
        }
    }
}



 
