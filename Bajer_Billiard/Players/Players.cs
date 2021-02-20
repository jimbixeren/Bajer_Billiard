using System;
using System.Collections.Generic;
using System.Text;


namespace Bajer_Billiard.Players
{
    public class Players
    {
        string Name;
        int playersNum;
        int pointLavet;
        int point;
        int gode;
        int res;
        int skævecount;
        int skæve;

       
        public string Deltager()
        {
            return playersNum.ToString();
            return Name.ToUpper();

        }




        public string Start()
        {

            res = 60;
           
            return res.ToString();

        }

        public string Gode()
        {

            res = point - gode;
            return res.ToString();


        }

        public string Skæve()
        {
            skævecount = skæve;
            return skævecount.ToString();


        }




    }
}
