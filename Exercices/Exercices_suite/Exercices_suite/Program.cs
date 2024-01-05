using System.Collections;
using System.Diagnostics;
using System.IO;

namespace Exercices_suite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercice 4-2
             

            int counter, test = 2, temp;

            Console.WriteLine("Afficher combien de nombres parfaits ?");
            counter = Convert.ToInt32(Console.ReadLine());

            while(counter > 0)
            {
                temp = 0;
                for (int i = 1; i < test; i++)
                {
                    if (test % i == 0)
                    {
                        temp += i;
                    }
                }
                if (temp == test)
                {
                    Console.WriteLine(test + " est un nombre parfait.");
                    counter--;
                }
                test++;
            }
            */

            /*
             * Exercice 4-4-1
             

            string temp;
            double temperature, temperature2;
            Console.WriteLine("Entrez votre température à convertir : ");
            temp = Console.ReadLine();
            string[] test = temp.Split(' ');
            temperature = Convert.ToDouble(test[0]);
            Console.WriteLine(temperature);
            if (test[1].Equals("C") && temperature > -273.15)
            {
                temperature2 = (temperature * 9 / 5) + 32;
                Console.WriteLine(temperature + "°C donne " + temperature2 + "°F");
            }
            else if (test[1].Equals("F") && temperature > -459.67)
            {
                temperature2 = (temperature - 32) * 5 / 9;
                Console.WriteLine(temperature + "°F donne " + temperature2 + "°C");
            }
            else
            {
                Console.WriteLine("Saisie hors paramètres !");
            }
            */

            /*
             * Exercice 5-1
             

            Dictionary<string, double> vegeList = new();
            string temp, vege;
            
            double price = 0;
            bool finished = false;
            do // boucle tant que l'utilisateur n'a pas entré "go" pour modifier l'état du booléen "finished"
            {
                Console.WriteLine("Saisissez les nom et prix des légumes (séparés d'un espace) : ");
                temp = Console.ReadLine(); // variable temporaire stockant l'entrée utilisateur
                if (temp.Equals("go"))
                {
                    finished = true; // booléen qui passe à true si "go" est saisi
                }
                else
                {
                    string[] splited = temp.Split(" "); // sinon la chaine de caractère est splitée avec l'espace comme sélécteur
                    vege = splited[0]; // vege récupère la valeur de la chaine de caractère (le nom du légume)
                    price = double.Parse(splited[1]); // price récupère le prix, converti en double
                    vegeList.Add(vege, price); // et les deux sont ajoutés au dictionnaire, sous un schéma clé/valeur
                } 
            }while (!finished);

            Output(vegeList);

            static void Output(Dictionary<string, double> vegeList)
            {
                string minPrice; // stockera le nom du légume le moins cher
                foreach (KeyValuePair<string, double> vege in vegeList) // boucle foreach sur les éléments du dictionnaire pour récupérer les clés et les valeurs associées
                {
                    Console.WriteLine("1 kilogramme de " + vege.Key + " coûte " + vege.Value + " euros.");
                }
                minPrice = vegeList.MinBy(kvp => kvp.Value).Key; // méthode de tri selon la valeur minimum et récupère la clé associée
                Console.WriteLine("Légume le moins cher au kilo : " + minPrice);
            }
            */


            /*
             * Exercice 5-2
             

            int score1 = 0, score2 = 0, value1 = 0, value2;
            Random rand = new();
            bool check;

            while (score1 < 10 && score2 < 10 && value1 >= 0)
            {
                do
                {
                    check = false;
                    Console.WriteLine("Entrez un nombre entre 0 et 2 : ");
                    value1 = int.Parse(Console.ReadLine());
                    if(value1 <= 2)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide");
                    }
                } while (!check);
                value2 = rand.Next(0, 3);
                
                if(value1 != value2)
                {
                    if(Scoring(value1, value2))
                    {
                        score1++;
                    }
                    else
                    {
                        score2++;
                    }
                }
                else
                {
                    Console.WriteLine("Égalité, 0 points");
                }   
                Console.WriteLine("score 1 : " + score1 + " ::: score 2 : " + score2);
            }
     
            static bool Scoring(int _value1, int _value2)
            {
                bool scorePlayer;
                int diff = _value1 > _value2 ? _value1 - _value2 : _value2 - _value1; 
                if(_value1 > _value2 && diff == 2 || _value1 < _value2 && diff == 1)
                {
                    scorePlayer = true;
                    Console.WriteLine(_value1 + " , " + _value2 + " : ");
                }
                else
                {
                    Console.WriteLine(_value1 + " , " + _value2 + " : ");
                    scorePlayer = false;
                }
                return scorePlayer;
            }
            */

            /*
             * Exercice 5-5
             

            string readText = File.ReadAllText("test.txt").ToLower(); // récupération d'un texte, en le forçant en minuscules
            int counter;
            ArrayList count = new();
            ArrayList charList = new();
            if(readText.Length >= 120)
            {
                for(char c = 'a'; c <= 'z'; ++c) // ici "c" prendra les lettres de l'alphabet successivement à chaque passage
                {
                    charList.Add(c); // pour les stocker dans une liste
                }

                for(int i = 0; i < charList.Count; i++) // boucle sur la liste de caractères
                {
                    counter = 0; // variable de compteur, réinitialisée à 0 pour le passage suivant
                    for(int j = 0; j < readText.Length; j++)
                    {
                        if (charList[i].Equals(readText[j])) // si la lettre de l'indice i est équivalente à la lettre du texte à l'indice j
                        {
                            counter++; // le compteur s'incrémente
                        }
                    }
                    count.Add(counter); // et ce compteur s'ajoute dans une liste avant le prochain passage
                }
            
                for(int k = 0; k < charList.Count; k++)
                {
                    Console.WriteLine(charList[k] + " : " + count[k]); // affiche la lettre et son score à l'indice k
                }
            }
            else
            {
                Console.WriteLine("Texte trop court.");
            }
           */

            /*
             * Exercice 6-2
             

            string first, second;

            Console.WriteLine("Saisissez le mot ou la phrase à tester : ");
            first = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(first);
            char[] charArray = first.ToCharArray();
            Array.Reverse(charArray);
            second = new string(charArray);
            if (first.Equals(second))
            {
                Console.WriteLine("C'est un palindrome");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un palindrome");
            }
            */

            /*
             * 
             */



            /*
             * Exercice 6-3
             

            string wordToGuess, test;
            char guess;
            int errors = 0, found = 0;
            char[] letters = {}, hanged = {};
            bool game = false, win = false, error = true;

            do // boucle pour déterminer si le mot entré est valide
            {
                Console.WriteLine("Entrez le mot à deviner : (5 lettres minimum)");
                wordToGuess = Console.ReadLine().ToLower();
                Console.Clear();
                if(wordToGuess.Length >= 5)
                {
                    letters = wordToGuess.ToCharArray(); // création de deux tableaux de caractères, l'un stockant le mot
                    hanged = wordToGuess.ToCharArray(); // l'autre servant au jeu, avec les tirets

                    for(int i = 1; i < hanged.Length -1; i++)
                    {
                        hanged[i] = '-';
                    }
                    game = true;
                    
                }
                else
                {
                    Console.WriteLine("Mot trop petit, recommencez");
                }
            } while (!game);
                
            while(errors < 6 && win == false)
            {
                
                Console.WriteLine("Erreurs: " + errors + "/6");
                Console.WriteLine(hanged);
                Console.WriteLine("Entrez une lettre à tester : ");
                test = Console.ReadLine().ToLower();
                guess = char.Parse(test);
                for(int j = 1; j < letters.Length - 1; j++)
                {
                    if (guess == letters[j])
                    {
                        Console.WriteLine("Lettre trouvée");
                        hanged[j] = letters[j];
                        error = false;
                    } 
                }

                if(hanged.SequenceEqual(letters))
                {
                    win = true;
                }

                if (error)
                {
                    errors++;  
                }
                error = true;
            }
            if (win)
            {
                Console.WriteLine("Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Vous avez perdu !");
            }
            



        }*/

        }
    }