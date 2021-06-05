using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NijatAlamadov_Project_SuperMarket
{
    class Program 
    {
        static void Main(string[] args)

        {
        start:
             
             
            Console.WriteLine("-------Supermarket--------");
            Console.WriteLine("Welcome:");
            Console.WriteLine("Searching items...");
            Console.WriteLine("Food:Spagetti,Rice,Yoghurt...");
            Console.WriteLine("Fruit and Vegetables:Apple,Banana,Tomato,Carrot...");
            Console.WriteLine("Clothes:Trousers,Shoes,Shirts...");
            Console.WriteLine("Equipments:Wrench,Lamp,Backsaw...");

            string[] spagetti = File.ReadAllText("spagettidata.txt").Split(' ');
            string spagettisearch = Console.ReadLine();
            bool condition = false;
            for(int i = 0;i<spagetti.Length;i++)
            {
                if(spagetti[i].Contains(spagettisearch) ==true)
                { condition = true;break; }
                else { condition = false; }
            }
            if(condition == true)
            {
                Console.WriteLine("{0} ID:13297,Name:Saville,Price:2,Unit:1,Type:Package,EXPdata:06062021  ", spagettisearch);

            }
            else
            {
                Console.WriteLine("{0} Click enter ...", spagettisearch);
            }

           
            string[] rice = File.ReadAllText("ricedata.txt").Split(' ');
            string ricesearch = Console.ReadLine();            
            for (int i = 0; i < rice.Length; i++)
            {
                if (rice[i].Contains(ricesearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:12891,Name:Village,Price:2,Unit:1,Type:Package,EXPdata:03042022  ", ricesearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter ...", ricesearch);
            }

             
            string[] apple = File.ReadAllText("appledata.txt").Split(' ');
            string applesearch = Console.ReadLine();
            for (int i = 0; i < apple.Length; i++)
            {
                if (apple[i].Contains(applesearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:12891,Name:Green,Price:2,Unit:1,Type:Quba,EXPdata:03042022  ", applesearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter ...", applesearch);
            }


            string[] yoghurt = File.ReadAllText("yoghurtdata.txt").Split(' ');
            string yoghurtsearch = Console.ReadLine();
            for (int i = 0; i < yoghurt.Length; i++)
            {
                if (yoghurt[i].Contains(yoghurtsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:14291,Name:Atena,Price:1,Unit:2,Type:Cupping,EXPdata:07072020  ", yoghurtsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter ...", yoghurtsearch);
            }


            string[] banana = File.ReadAllText("bananadata.txt").Split(' ');
            string bananasearch = Console.ReadLine();
            for (int i = 0; i < banana.Length; i++)
            {
                if (banana[i].Contains(bananasearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:223513,Name:Afr,Price:3,Unit:3,Type:Fresh,EXPdata:07062020  ", bananasearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter ...", bananasearch);
            }



            string[] tomato = File.ReadAllText("tomatodata.txt").Split(' ');
            string tomatosearch = Console.ReadLine();
            for (int i = 0; i < tomato.Length; i++)
            {
                if (tomato[i].Contains(tomatosearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:46313,Name:Reds,Price:3,Unit:1,Type:OriginalVillage,EXPdata:02062020  ", tomatosearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", tomatosearch);
            }


            string[] carrot = File.ReadAllText("carrotdata.txt").Split(' ');
            string carrotsearch = Console.ReadLine();
            for (int i = 0; i < carrot.Length; i++)
            {
                if (carrot[i].Contains(carrotsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:77313,Name:Rabs,Price:5,Unit:1,Type:Old,EXPdata:22062020  ", carrotsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", carrotsearch);
            }


            string[] trousers = File.ReadAllText("trousersdata.txt").Split(' ');
            string trouserssearch = Console.ReadLine();
            for (int i = 0; i < trousers.Length; i++)
            {
                if (trousers[i].Contains(trouserssearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:421282991,Name:Bershkha,Price:100,Unit:1,Type:Slim,EXPdata:06062040  ", trouserssearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", trouserssearch);
            }


            string[] shirt = File.ReadAllText("shirtdata.txt").Split(' ');
            string shirtsearch = Console.ReadLine();
            for (int i = 0; i < shirt.Length; i++)
            {
                if (shirt[i].Contains(shirtsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:31282991,Name:Calliope,Price:80,Unit:1,Type:Loose,EXPdata:06062045  ", shirtsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", shirtsearch);
            }

            string[] shoes = File.ReadAllText("shoesdata.txt").Split(' ');
            string shoessearch = Console.ReadLine();
            for (int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i].Contains(shoessearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:1282991,Name:FLO,Price:150,Unit:1,Type:Sport,EXPdata:06062027  ", shoessearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", shoessearch);
            }


            string[] lamp = File.ReadAllText("lampdata.txt").Split(' ');
            string lampsearch = Console.ReadLine();
            for (int i = 0; i < lamp.Length; i++)
            {
                if (lamp[i].Contains(lampsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:2991,Name:Azerisiq,Price:20,Unit:1,Type:MoreLighter,EXPdata:06062025  ", lampsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", lampsearch);
            }


            string[] wrench = File.ReadAllText("wrenchdata.txt").Split(' ');
            string wrenchsearch = Console.ReadLine();
            for (int i = 0; i < wrench.Length; i++)
            {
                if (wrench[i].Contains(wrenchsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:82991,Name:Tool,Price:125,Unit:1,Type:Allthings,EXPdata:06062040  ", wrenchsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", wrenchsearch);
            }

            string[] backsaw = File.ReadAllText("backsawdata.txt").Split(' ');
            string backsawsearch = Console.ReadLine();
            for (int i = 0; i < backsaw.Length; i++)
            {
                if (backsaw[i].Contains(backsawsearch) == true)
                { condition = true; break; }
                else { condition = false; }
            }
            if (condition == true)
            {
                Console.WriteLine("{0} ID:32391,Name:Tool,Price:87,Unit:1,Type:Allthings,EXPdata:06062040  ", backsawsearch);
            }
            else
            {
                Console.WriteLine("{0} Click enter...", backsawsearch);
            }

            goto start;

 
 
         
            
             





































            /*--------------------------------------------------------------------------------------

            Equipments lamp = new Equipments(2991, "Azerisiq", 20,1, "MoreLighter", 06062025);
             Equipments wrench = new Equipments(82991, "Tool", 125, 1, "Allthings", 06062040);
             Equipments backsaw = new Equipments(32391, "Tool", 87, 1, "Allthings", 06062040);


             Food spagetti = new Food(13297, "Saville", 2, 1, "Package", 03042022);
             Food rice = new Food(12891, "Village", 3, 1, "Package", 06062021);
             Food yoghurt = new Food(14291, "Atena", 1, 2, "Cupping-Glass ", 07072020);

             FruitsandVegetables apple = new FruitsandVegetables(21313, "Green", 1, 3, "Quba", 03062020);
             FruitsandVegetables banana = new FruitsandVegetables(223513, "Afr", 3, 3, "Fresh", 07062020);
             FruitsandVegetables tomato = new FruitsandVegetables(46313, "Reds", 3, 1, "OriginalVillage", 02062020);
             FruitsandVegetables carrot = new FruitsandVegetables(77313, "Rabs", 5, 1, "Old", 22062020);
             Clothes trousers = new Clothes(421282991, "Bershkha", 100, 1, "Slim", 06062040);
             Clothes shirt = new Clothes(31282991, "Calliope", 80, 1, "Loose", 06062045);
             Clothes shoes = new Clothes(1282991, "FLO", 150, 1, "Sport", 06062027);*/

            /*

               Console.WriteLine("------------Welcome to supermarket-----------------\n");
               Console.WriteLine("Content of markeet\n");

               Console.WriteLine("1.Food");
               Console.WriteLine("2.Fruits and Vegetables");
               Console.WriteLine("3.Clothes");
               Console.WriteLine("4.Equipments");
               //=========================================================

               int Select = int.Parse(Console.ReadLine());
               switch (Select)
               {

                   case 1:
                       Console.WriteLine("1.Spagetti");
                       Console.WriteLine("2.Rice");
                       Console.WriteLine("3.Yoghurt");
                       int Select2 = int.Parse(Console.ReadLine());
                       switch (Select2)
                       {
                           case 1:
                               Console.WriteLine("ID:" + spagetti.ID  + "\nName:"+ spagetti.Name + "\nPrice:" +spagetti.Price+ "$"+ "\nUnit:" + spagetti.Unit+ "\nType:" + spagetti.Type + "\nExpDate:" + spagetti.Expirationdate); 
                               break;
                           case 2:
                               Console.WriteLine("ID:" + rice.ID + "\nName:" + rice.Name + "\nPrice:" + rice.Price + "$" + "\nUnit:" + rice.Unit + "\nType:" + rice.Type + "\nExpDate:" + rice.Expirationdate);
                               break;
                           case 3:
                               Console.WriteLine("ID:" + yoghurt.ID + "\nName:" + yoghurt.Name + "\nPrice:" + yoghurt.Price + "$" + "\nUnit:" + yoghurt.Unit + "\nType:" + yoghurt.Type + "\nExpDate:" + yoghurt.Expirationdate);
                               break;
                           default:
                               Console.WriteLine("Invalid choice please run again and choose 1-3");
                               break;
                       }

                       break;




                   case 2:
                       Console.WriteLine("1.Apple");
                       Console.WriteLine("2.Banana");
                       Console.WriteLine("3.Tomato");
                       Console.WriteLine("4.Carrot");
                       int Select3 = int.Parse(Console.ReadLine());
                       switch (Select3)
                       {
                           case 1:
                               Console.WriteLine("ID:" + apple.ID + "\nName:" + apple.Name + "\nPrice:" + apple.Price + "$" + "\nUnit:" + apple.Unit + "\nType:" + apple.Type + "\nExpDate:" + apple.Expirationdate);
                               break;
                           case 2:
                               Console.WriteLine("ID:" + banana.ID + "\nName:" + banana.Name + "\nPrice:" + banana.Price + "$" + "\nUnit:" + banana.Unit + "\nType:" + banana.Type + "\nExpDate:" + banana.Expirationdate);
                               break;
                           case 3:
                               Console.WriteLine("ID:" + tomato.ID + "\nName:" + tomato.Name + "\nPrice:" + tomato.Price + "$"+ "\nUnit:" + tomato.Unit + "\nType:" + tomato.Type + "\nExpDate:" + tomato.Expirationdate);
                               break;
                           case 4:
                               Console.WriteLine("ID:" + carrot.ID + "\nName:" + carrot.Name + "\nPrice:" + carrot.Price + "$" + "\nUnit:" + carrot.Unit + "\nType:" + carrot.Type + "\nExpDate:" + carrot.Expirationdate);
                               break;
                           default:
                               Console.WriteLine("Invalid choice please run again and choose 1-4");
                               break;
                       }
                       break;




                   case 3:
                       Console.WriteLine("1.Trousers");
                       Console.WriteLine("2.Shirts");
                       Console.WriteLine("3.Shoes");
                       int Select4 = int.Parse(Console.ReadLine());
                       switch (Select4)
                       {
                           case 1:
                               Console.WriteLine("ID:" + trousers.ID + "\nName:" + trousers.Name + "\nPrice:" + trousers.Price + "$" + "\nUnit:" + trousers.Unit + "\nType:" + trousers.Type + "\nExpDate:" + trousers.Expirationdate);
                               break;
                           case 2:
                               Console.WriteLine("ID:" + shirt.ID + "\nName:" + shirt.Name + "\nPrice:" + shirt.Price + "$" + "\nUnit:" + shirt.Unit + "\nType:" + shirt.Type + "\nExpDate:" + shirt.Expirationdate);
                               break;
                           case 3:
                               Console.WriteLine("ID:" + shoes.ID + "\nName:" + shoes.Name + "\nPrice:" + shoes.Price + "$" + "\nUnit:" + shoes.Unit + "\nType:" + shoes.Type + "\nExpDate:" + shoes.Expirationdate);
                               break;
                           default:
                               Console.WriteLine("Invalid choice please run again and choose 1-3");
                               break;
                       }
                       break;
                   case 4:
                       Console.WriteLine("1.Lamp");
                       Console.WriteLine("2.Wrench");
                       Console.WriteLine("3.Backsaw");
                       int Select5 = int.Parse(Console.ReadLine());
                       switch (Select5)
                       {
                           case 1:
                               Console.WriteLine("ID:" + lamp.ID + "\nName:" + lamp.Name + "\nPrice:" + lamp.Price + "$" + "\nUnit:" + lamp.Unit + "\nType:" + lamp.Type + "\nExpDate:" + lamp.Expirationdate);
                               break;
                           case 2:
                               Console.WriteLine("ID:" + wrench.ID + "\nName:" + wrench.Name + "\nPrice:" + wrench.Price + "$" + "\nUnit:" + wrench.Unit + "\nType:" + wrench.Type + "\nExpDate:" + wrench.Expirationdate);
                               break;
                           case 3:
                               Console.WriteLine("ID:" + backsaw.ID + "\nName:" + backsaw.Name + "\nPrice:" + backsaw.Price + "$" + "\nUnit:" + backsaw.Unit + "\nType:" + backsaw.Type + "\nExpDate:" + backsaw.Expirationdate);
                               break;
                           default:
                               Console.WriteLine("Invalid choice please run again and choose 1-3");
                               break;
                       }

                       break;

                   default:
                       Console.WriteLine("Invalid choice please run again and choose 1-4");
                       break;
               }*/









             


        }
    }
}
