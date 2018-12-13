using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2
{
    class Program
    {

        static string[] idlist = {"asgwdcmbrkerohqoutfylvzpnx", "asgwjcmbrkejihqoutfylvipne", "asgwjcmbrkedihqoutvylizpnz", "azgsjcmbrkedihqouifylvzpnx", "asgwucmbrktddhqoutfylvzpnx", "asgwocmbrkedihqoutfylvzivx", "aqgwjcmbrkevihqvutfylvzpnx", "tsgljcmbrkedihqourfylvzpnx", "asgpjcmbrkedihqoutfnlvzsnx", "astwjcmbrktdihqrutfylvzpnx", "asgwjcmbrpedhhqoutfylvzynx", "xsgwjcmbrkedieqowtfylvzpnx", "asgwjcmbvkedihfoutnylvzpnx", "asgwjcmtrkedihqouafylvzcnx", "asgwjcmbrkedihqoutfylvxpvm", "usgwjcmbrkedihqortfyuvzpnx", "asgwjcmbrwedihqoutfylizpix", "asgrjcvbrkedixqoutfylvzpnx", "asgwjcmbrogdihqoutfelvzpnx", "aggwjcmbrkesihqoutoylvzpnx", "asgtjccbrkedihqoutfrlvzpnx", "asgcucmbrbedihqoutfylvzpnx", "esgwjcmbrkedihqsutfylvzcnx", "asgwjcmbrkedrhqoutfyobzpnx", "mngwjcbbrkedihqoutfylvzpnx", "asgwjcrbrkeoihqyutfylvzpnx", "apgwjcmbrkednhqogtfylvzpnx", "asgwjcwbrkedihqoutfylplpnx", "asgwjcmbrkfdihqoutfxlvzpyx", "aegwjcmbrkedihqoutfylbxpnx", "asgljcmbrkedixqoutaylvzpnx", "aigwjcmbrkedihqouhfylvzpex", "asgwjbmbrkedihqoutfylfzpnp", "asgwjcmzroedihqoutcylvzinx", "asgwjcwbrieuihqoutfylvzpnx", "aagwjcmbrkedjhqdutfylvzpnx", "ahgwjcmbrkedihqsutfylvzpfx", "asgwjcmbrkedihzosttylvzpnx", "aegwjcmbrkedioqnutfylvzpnx", "asgwjcmbykidihqoutfysvzpnx", "asgwkcxbrkeddhqoutfylvzpnx", "ashwjcmbrkeeihqoutfylvzknx", "acgwjcmbrqedihqoqtfylvzpnx", "asgwjcmtrkedihooutfylszpnx", "asgwjcmbrkmdihqfutrylvzpnx", "asgwjcmbrkedihqoutjylvapnn", "asgwjcmbwkedihqoutkylkzpnx", "asgwjrmbrkedihqoutfycnzpnx", "asgwtcmbrkedihqoqtfylozpnx", "asgajcmbrkedihqoutuylvzpny", "asgwjcmbykedihqoutfylfzpwx", "asgwjcsbrkedihpoutfylvvpnx", "hsdwjcmbrvedihqoutfylvzpnx", "asgwjcmbrkedihqoutfdmszpnx", "adgwjcmbrtidihqoutfylvzpnx", "augwjcmbriedihqoutgylvzpnx", "asgwjvmbreedihqoutfllvzpnx", "asgwjcnbfkedihqoltfylvzpnx", "asgwjcmbykddihqoutqylvzpnx", "ajgwjcmbrkedihqoutfylvpvnx", "asgwjcmbrkydihqoutfylszpnl", "xsgwjcmbrkqdihqoutfylvkpnx", "asgwjcmbrkedimqoutfklvzknx", "csgwjbmbrkedihqoftfylvzpnx", "asgwjcmbjkedihjoutfylvzpnn", "asgwjcmprkedihqoulfalvzpnx", "asgwjcmbrvediqqoutfyuvzpnx", "asgwjambrkedhhqoutkylvzpnx", "asgejcmbrkidihqoutfylvzpnk", "hsiwjcmbrkedihqoutfylvzpnq", "asswjczbrkedihqoutfylczpnx", "asgwjnmbrkedyhzoutfylvzpnx", "asgwscmbrkedihqoutfklvlpnx", "asgwlcmbrktdihqoutfylvzpax", "asfwjcmerkedihqoutfylvipnx", "asgwjcmbrkeditqoeafylvzpnx", "asgwgcmbrkesihqoutfylyzpnx", "fsgwjcmbrkedihqouvfyavzpnx", "asgwjcmbrpedwhqoutfylmzpnx", "asgwjcmbrkzdzhqoucfylvzpnx", "asgwjcmnrketmhqoutfylvzpnx", "asgwjcmbrkedihxoutsylvzpnh", "asgwjcobrkedihqoutfrlvzpox", "asgwjcmbrkedihqootfylxzpox", "asgjjcmcrkedihqoutfylmzpnx", "lsgwjcmbrkedihqoutfyqvzunx", "asgwjcmbrwedihqoutoylvzpnu", "aszwjcmbtkedihqoutfylczpnx", "asgwjcmbykedihqoutfylvgpex", "asgijcmbrkedilqoutkylvzpnx", "astwxcmzrkedihqoutfylvzpnx", "akgwjcmbnkedihqfutfylvzpnx", "asgwjcmbrqndivqoutfylvzpnx", "asgwjrmbrleqihqoutfylvzpnx", "asgwjcmbrkevihqoutfxlvzpvx", "asbwjcmbrkedihqoutfelvwpnx", "asewjcbbrkmdihqoutfylvzpnx", "asgwjcmbrkeaihxoutfylpzpnx", "asgwjzmbrkedihqrotfylvzpnx", "asgwjcmbrkedihqoutgdxvzpnx", "asgwjcwbrkmdihqoutfylvzlnx", "asgwjcmbrkegihqoutfylrzpax", "ajgwjcmbrkegihqhutfylvzpnx", "asgwjcmbrzedihqhutfylvkpnx", "asgwjcmwrkedihqouhfylkzpnx", "aygwjcmbrkedihqoutfdlvzpnr", "asgwjcmbrkednhqoutiylvypnx", "aqgwjcmbrkezihqoutfylvzonx", "bsgwjcmbrkedihqouhfylvzsnx", "asgwjcmcrkedihqokyfylvzpnx", "asgsjcmbrkewiyqoutfylvzpnx", "asgwpcmbrkejihqoutfylzzpnx", "asgwjumbrkedbeqoutfylvzpnx", "asgwjcmbrkedihpoutqylqzpnx", "awgwjcmbrredihqoutfylvzpna", "asgwjsmbraedihqoutfylvzpvx", "asgwncmbrkedihqoutfyljzrnx", "asgwncmbrkedihqohtfylvzonx", "asgwjcmbrkedihqlutfylvypux", "asgwjcmbbkedihooutfylkzpnx", "asghjcmsryedihqoutfylvzpnx", "asgwjcmbrkevihqoulfzlvzpnx", "asggjcmbrkedizqoutfylvzknx", "asbwjcmbriedihqoutfylvmpnx", "asgwjcmbrkedqbqoutfylvzenx", "asgwjcmprkedihqoutfylvzknp", "asgwjcmbrkerihqoutfwlvzpno", "asgwjcmvrkesihqoutrylvzpnx", "asgzjcmbrkedihqoutfnlvbpnx", "asfwjcmbrkhdihqoutfylpzpnx", "asgwjcmbskedihqdutfyyvzpnx", "asgwjcmzrkedihqoutcylvzinx", "asgwjcmbrkedibqoutfylvjonx", "asgwjcmbrbedihqoutfylmzbnx", "asgwjcmbrkedhhqoutmylczpnx", "asgwjcmbrkbgihqoutzylvzpnx", "asgwjcfbrkedihqoupfyxvzpnx", "asiwjcmbzkedihqoutfyluzpnx", "asvwjcmbrkedihqoitfylvzpns", "asgwjcmxikedihqoutfyevzpnx", "asgwjcmbrkedioqoutfylvzwox", "asgwjcmbrkedivqoutjyuvzpnx", "asgwjcmbkkydihqrutfylvzpnx", "asgwjcmbrkxdiuqoutfylvopnx", "asgwjcmbrkedihqouthylvzpra", "asgwjcmbrzedimloutfylvzpnx", "asgwjcmbrkedmhqoulfytvzpnx", "asgwjcmbrkzdihqrutfysvzpnx", "ssgwjcmxrkedihqoutftlvzpnx", "asgwjcmbrkedihqoutfajvzynx", "asgwjcmbrkqdihqxuufylvzpnx", "asmwjcabrkedihqouxfylvzpnx", "asgwjcmbrkeeihqoatfycvzpnx", "asgwjcjbrgedjhqoutfylvzpnx", "asgljcmtrkedihqoutoylvzpnx", "asgwjcmbrkedigqouzfylvzpvx", "ajgvjcmbkkedihqoutfylvzpnx", "asgwjcmbrkedihqtugfygvzpnx", "asgbjcmbrkedihboftfylvzpnx", "asgwjwmbrkedihqontfylhzpnx", "asgwjfmhrkedihqoutfylvqpnx", "asgwjxmbrkedihqoutzylvzpnj", "asgwjcrlrkedihqoutfylvzpsx", "aygwjcmbrkedihqoutsylvzdnx", "zsgwjcmbrkedihjogtfylvzpnx", "asgwjxmbrkegihqoutfylvopnx", "asgwjcmbrkedihqhutfylvzcnr", "asgwicmbrkewihvoutfylvzpnx", "asqwjcmbvkedihqoutfylvzknx", "asgwjcmbrkedihqoktfyevzpnu", "asgwjcmbrkudihqoutfylqzznx", "asgwjdmbrkedihqoutfylvvdnx", "asgwjcmbrkwmihqautfylvzpnx", "asgwjcmbrxedihqoctfyldzpnx", "asgwjdmbrkedjhqoutfyfvzpnx", "asgwjcmtrzedihqoutfylvzpnm", "bpgwjcmbrmedihqoutfylvzpnx", "asgwjctbrkedihqoqtfynvzpnx", "askhjcmbrkedihqoutfylvzrnx", "asgkjcmblkehihqoutfylvzpnx", "asgwjjmbrkedvhqoutfhlvzpnx", "asgwjcmbrkedihqoupzylvzknx", "asgwjcmbukedchqoutfylizpnx", "askwjcmdrkedihqoutwylvzpnx", "asgwjcmbtkcdihloutfylvzpnx", "asgwjcmbrkedwgqoutvylvzpnx", "asmwjcmbrkedihqoutfylozpnc", "asgwjcmbriedibqouofylvzpnx", "asgnjcmcrkedihqoupfylvzpnx", "asgzjcmbrksdihqoutiylvzpnx", "asgwjcrbkkedihqouafylvzpnx", "asgwjcmbkkvdihqqutfylvzpnx", "astwjcqbrkedihqoutfylvzpvx", "asgwjcmhrkehihqoutfylvzvnx", "asgwjcmbraeduhqoutmylvzpnx", "asgwjcmbrkedihquutnylvzptx", "asgwjcmbrkedilqoftfylvzpnz", "akgwjmmbrkedihqoutfylxzpnx", "asgwjcmbrkhxikqoutfylvzpnx", "asgcjcmetkedihqoutfylvzpnx", "fsgwjcmsrkedihooutfylvzpnx", "gsgwjcmbrkedihdoutfylvzdnx", "asgwtccbrkedihqoutfylvwpnx", "asuwjcmbrkedihqcutfylvzpox", "asgwacmbrkodihqlutfylvzpnx", "asgwjcmbrkediuqoutfylqhpnx", "asgwjcmbrkwdrhqoutfylvzpno", "angwjcsblkedihqoutfylvzpnx", "aigwjcmbyoedihqoutfylvzpnx", "adgwjcmbrkedihqtutfylyzpnx", "asgwjzmbrkeeihqputfylvzpnx", "asgwjcmbrkwdihqoutfylvzpwc", "asgpjcmbrkgdihqbutfylvzpnx", "osgwjmmbrkedijqoutfylvzpnx", "asgjjcmbrkkdihqoutfylvzynx", "asgwjcnerwedihqoutfylvzpnx", "azgwhcmbrkedicqoutfylvzpnx", "asnwjcmbrsedihqoutfylvzpnm", "hsgwjcmgrkedihqoutfilvzpnx", "asgwscmbrkjdihqoutfylvzpnm", "asgbjbmbrkedhhqoutfylvzpnx", "aswwjcmtrkedihqjutfylvzpnx", "asgwicmbrbedihqoutfylvzpnm", "asgwjcubrkedihqoutfylvbnnx", "asvwjcmbrkehihqoutfylhzpnx", "gsgwjcmbrkedihqoutsklvzpnx", "asgwjcubikedihqoitfylvzpnx", "asgwjpmbskedilqoutfylvzpnx", "aigwjcmbrxedihqoutyylvzpnx", "asgwjcpbrkedihxoutfynvzpnx", "asgwjcmbrkegihqoutfklvzcnx", "asgwjvubrkedjhqoutfylvzpnx", "asgwjcabrkedihqoutfyivzplx", "asgwjcxbrkedihqgutfylvepnx", "asgwlcmbrkedihqoutqylvwpnx", "asgwjhmbrkydihqhutfylvzpnx", "asgwjcmbrkedihqoutfylwzone", "asgwycmbrkadihqoutuylvzpnx", "asgwjcybrkedihqoftfylvzpne", "asgwjcmnrkedihrodtfylvzpnx", "asgwicmwrkedihqoutfyovzpnx", "aqgwjlmbrkedilqoutfylvzpnx", "asgwjcmzskwdihqoutfylvzpnx", "asgwjcmdrkebihqoutfylvjpnx", "asgwjcmbrkpdihqoutfylxzphx", "asgwjcmbrkedixqoutlylfzpnx", "asgwjcmbrkadihqoutfylvlpdx", "asgejcmqrkedyhqoutfylvzpnx", "asgwjcmvroedihpoutfylvzpnx", "asgwjcmxrkedihqoutfyivzpmx"};

        static void Main(string[] args)
        {
            List<box> boxList = new List<box>();
            List<ident> identList = new List<ident>();
            int nofTwoLetters = 0;
            int nofThreeLetter = 0;
            foreach (string idstr in idlist) boxList.Add(new box(idstr));

            foreach(box box in boxList)
            {
                ident idt = new ident();
                idt.box = box;
                foreach (KeyValuePair<string, int> kvp in box.LetterList)
                {
                    if (kvp.Value == 2) idt.NofTwoLetters++;
                    if (kvp.Value == 3) idt.NofThreeLetters++;
                }
                if (idt.NofTwoLetters > 0) nofTwoLetters++;
                if (idt.NofThreeLetters > 0) nofThreeLetter++;
                identList.Add(idt);
            }

            Console.WriteLine("Nof two letters: {0}, nof three letters {1}, {0}x{1}={2}", nofTwoLetters, nofThreeLetter, nofTwoLetters * nofThreeLetter);

            int[,] lvdist = new int[idlist.Length,idlist.Length];
            int max = 0;
            int idi = 0;
            int idy = 0;

            for (int i = 0; i < idlist.Length; i++)
            {
                for(int y = 0; y < idlist.Length; y++)
                {
                    if (i == y) continue;

                    for (int l = 0; l < idlist[0].Length; l++)
                    {
                        if(idlist [i].ToCharArray()[l] == idlist[y].ToCharArray()[l]) lvdist[i, y]++;
                    }

                    if (lvdist[i, y] > max )
                    {
                        max = lvdist[i, y];
                        idi = i;
                        idy = y;
                    }
                    else if (lvdist[i, y] == max)
                    {
                        Console.WriteLine("sigularity for {0} at {1}, {2}", max, i, y);
                    }
                    // From previouse runs, I know the max. value is 25
                    if (lvdist[i, y] >= 25)
                    {
                        Console.WriteLine(idlist[i]);
                        Console.WriteLine(idlist[y]);
                        Console.WriteLine("--------------------------");
                    }

                }
            }

            Console.WriteLine("");
            for (int l = 0; l < idlist[0].Length; l++)
            {
                if (idlist[idi].ToCharArray()[l] == idlist[idy].ToCharArray()[l]) Console.Write(idlist[idi].ToCharArray()[l]);
            }


            Console.ReadLine();

        }


        // len_s and len_t are the number of characters in string s and t respectively
        static int LevenshteinDistance(string s, int len_s, string t, int len_t)
        { 
          int cost;

          /* base case: empty strings */
          if (len_s == 0) return len_t;
          if (len_t == 0) return len_s;

          /* test if last characters of the strings match */
          if (s[len_s - 1] == t[len_t - 1])
              cost = 0;
          else
              cost = 1;

          /* return minimum of delete char from s, delete char from t, and delete char from both */
          return Math.Min(LevenshteinDistance(s, len_s - 1, t, len_t    ) + 1,
                         Math.Min(LevenshteinDistance(s, len_s    , t, len_t - 1) + 1,
                         LevenshteinDistance(s, len_s - 1, t, len_t - 1) + cost));
        }
}

    class box
    {
        int[] letters = new int[26]; // index 0=a...25=z
        public SortedList<string, int> LetterList = new SortedList<string, int>();

        public box(string id)
        {

            char[] splitId = id.ToLower().ToCharArray();
            foreach(char symb in splitId)
            {
                // count letters
                letters[symb - 'a']++;
            }
            // sort the list
            for (int i = 0; i < 26; i++) LetterList.Add(((char)('a' + i)).ToString(), letters[i]);
        }
    }

    class ident
    {
        public box box;
        public int NofTwoLetters;
        public int NofThreeLetters;
    }
}
