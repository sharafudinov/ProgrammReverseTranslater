using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTranslater
{
    class WorkClassWithWord
    {
        public string[] InsertStringMass(string Insert)
        {
            return Insert.Split(new[] { ' ', ']', '[',  '(', ')', '&' }, StringSplitOptions.RemoveEmptyEntries);
        }

        char buffer;
        public string[] Decoder(string[] Inserted)
        {
                Char[] StringForDecoder = new Char[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю', 'Ё' };
                for (int i = 0; i < Inserted.Length; i++)
                {
                    string temp = Inserted[i];
                    string temp2 = string.Empty;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        for (int x = 0; x < StringForDecoder.Length; x++)
                        {
                            if (temp[j] == StringForDecoder[x])
                            {
                                buffer = temp[j];
                                j += 2;
                            }
                            else if (temp[j] != StringForDecoder[x])
                            {
                                buffer = temp[j];
                            }

                        }
                        temp2 += buffer;
                    }
                    Inserted[i] = temp2;
                }
            return Inserted;
        }
        bool Result, nullbull;
        bool chk = false;
        public bool TestStringCorrectValue(string[] Inserted)
        {
            
            Char[] StringForDecoder = new Char[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю', 'Ё' };
            for (int i = 0; i < Inserted.Length; i++)
            {
                Result = nullbull;
                string temp = Inserted[i];
                int lngTmp = temp.Length;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (chk == true)
                    {
                        chk = false;
                        break;
                    }
                    else
                    {
                        for (int x = 0; x < StringForDecoder.Length; x++)
                        {
                            if (j + 3 > lngTmp)
                            {
                                chk = true;
                                break;
                            }
                            else
                            {
                                if (temp[j] == StringForDecoder[x])
                                {
                                    string chck1 = temp[j].ToString() + temp[j + 1].ToString() + temp[j + 2].ToString();
                                    string chck2 = temp[j].ToString() + "c" + temp[j].ToString();
                                    for (int f = 0; f < chck1.Length; f++)
                                    {
                                        if (chck1[f] == chck2[f])
                                        {
                                            Result = true;
                                        }
                                        else
                                        {
                                            Result = false;
                                        }
                                    }
                                    j += 3;
                                }
                            }
                        }
                    }
                }
            }
            return Result;
        }
    }
}
