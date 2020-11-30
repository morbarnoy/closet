using System;
using System.Collections.Generic;
using System.Text;

namespace MyClosett.Algorithm
{
    public class MatchAlgorithm
    {
        public Shirt[] longshirts = new Shirt[10];
        public Bottom[] longpants = new Bottom[10];
        public Shirt[] shortshirts = new Shirt[10];
        public Bottom[] shortpants = new Bottom[10];
        public FullBody[] dress = new FullBody[10];
        public FullBody[] suit = new FullBody[10];

        public MatchAlgorithm() { }

        public int ChangeOcastoinToNum(string occasion)
        {

            if (occasion == "casual")
            {
                return 2;
            }
            else if (occasion == "fancy")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void matchpants(Shirt toMatch, Bottom[] optionalPants)
        {

            int ocas1 = ChangeOcastoinToNum(toMatch.Ocassion);
            int temp = 0;
            int a = 0;

            if (toMatch.type == "Long Sleve Shirt")
            {
                temp = 0;
            }
            else
            {
                temp = 200;
            }

            if (temp < 25)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < longpants.Length; i++)
                    {
                        if (longpants[i] != null)
                        {
                            string ocas2 = longpants[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                optionalPants[a] = longpants[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < longpants.Length; i++)
                    {
                        if (longpants[i] != null)
                        {
                            string ocas2 = longpants[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                optionalPants[a] = longpants[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {

                    for (int i = 0; i < longpants.Length; i++)
                    {
                        if (longpants[i] != null)
                        {
                            string ocas2 = longpants[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                optionalPants[a] = longpants[i];
                                a++; ;
                            }
                        }
                    }
                }
            }

            else if (temp > 25)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < shortpants.Length; i++)
                    {
                        if (shortpants[i] != null)
                        {
                            string ocas2 = shortpants[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                optionalPants[a] = shortpants[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < shortpants.Length; i++)
                    {
                        if (shortpants[i] != null)
                        {
                            string ocas2 = shortpants[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                optionalPants[a] = shortpants[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {
                    for (int i = 0; i < shortpants.Length; i++)
                    {
                        if (shortpants[i] != null)
                        {
                            string ocas2 = shortpants[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                optionalPants[a] = shortpants[i];
                                a++;
                            }
                        }
                    }
                }
            }
        }
        public Bottom MatchBottomColor(Shirt toMatch)
        {
            Bottom[] optionalPants = new Bottom[15];

            matchpants(toMatch, optionalPants);

            string colorshirt = toMatch.Color;

            for (int i = 0; i < optionalPants.Length; i++)
            {
                string colorpants = optionalPants[i].Color;

                if (colorshirt == "orange" && colorpants == "blue")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "blue" && colorpants == "orange")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "red" && colorpants == "green")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "green" && colorpants == "red")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "yellow" && colorpants == "purple")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "purple" && colorpants == "yellow")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "white" && colorpants != "white")
                {
                    return optionalPants[i];
                }
                else if (colorshirt == "black" && colorpants != "black")
                {
                    return optionalPants[i];
                }
                else if (colorshirt != "black" && colorpants == "black")
                {
                    return optionalPants[i];
                }
                else if (colorshirt != "white" && colorpants == "white")
                {
                    return optionalPants[i];
                }
            }
            return null;
        }

        public void ChooseShirt(int temp, int ocas1, Shirt[] ret)
        {
            int a = 0;
            if (temp < 23)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < longshirts.Length; i++)
                    {
                        if (longshirts[i] != null)
                        {
                            string ocas2 = longshirts[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                ret[a] = longshirts[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < longshirts.Length; i++)
                    {
                        if (longshirts[i] != null)
                        {
                            string ocas2 = longshirts[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                ret[a] = longshirts[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {
                    for (int i = 0; i < longshirts.Length; i++)
                    {
                        if (longshirts[i] != null)
                        {
                            string ocas2 = longshirts[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                ret[a] = longshirts[i];
                                a++;
                            }
                        }
                    }
                }
            }
            else if (temp > 23)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < shortshirts.Length; i++)
                    {
                        if (shortshirts[i] != null)
                        {
                            string ocas2 = shortshirts[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                ret[a] = shortshirts[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < shortshirts.Length; i++)
                    {
                        if (shortshirts[i] != null)
                        {
                            string ocas2 = shortshirts[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                ret[a] = shortshirts[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {
                    for (int i = 0; i < shortshirts.Length; i++)
                    {
                        if (shortshirts[i] != null)
                        {
                            string ocas2 = shortshirts[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                ret[a] = shortshirts[i];
                                a++;
                            }
                        }
                    }
                }
            }
        }
        public void ChooseFullbody(int temp, int ocas1, FullBody[] ret)
        {
            int a = 0;
            if (temp < 23)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < suits.Length; i++)
                    {
                        if (suits[i] != null)
                        {
                            string ocas2 =suits[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                ret[a] = longshirts[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < suits.Length; i++)
                    {
                        if (suits[i] != null)
                        {
                            string ocas2 = suits[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                ret[a] = suits[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {
                    for (int i = 0; i < suits.Length; i++)
                    {
                        if (suits[i] != null)
                        {
                            string ocas2 = suits[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                ret[a] = suits[i];
                                a++;
                            }
                        }
                    }
                }
            }
            else if (temp > 23)
            {
                if (ocas1 == 0)
                {
                    for (int i = 0; i < dress.Length; i++)
                    {
                        if (dress[i] != null)
                        {
                            string ocas2 = dress[i].Ocassion;
                            if (ocas2 == "work")
                            {
                                ret[a] = dress[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 1)
                {
                    for (int i = 0; i < dress.Length; i++)
                    {
                        if (dress[i] != null)
                        {
                            string ocas2 = dress[i].Ocassion;
                            if (ocas2 == "fancy")
                            {
                                ret[a] = dress[i];
                                a++;
                            }
                        }
                    }
                }
                else if (ocas1 == 2)
                {
                    for (int i = 0; i < dress.Length; i++)
                    {
                        if (dress[i] != null)
                        {
                            string ocas2 = dress[i].Ocassion;
                            if (ocas2 == "casual")
                            {
                                ret[a] = dress[i];
                                a++;
                            }
                        }
                    }
                }
            }
        }

        //1. choose shirt = finds shirt by kriteryonim
        //2. to call matchbottomcolor with the shirt mentioned above;
    }
}
