using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
     internal class Transfer
    {
        private double yuan;
        private double rupee;
        private double egypt;
        private double france;
        private double brazil;
        private double argentine;
        private double Saudi;
        private double canada;
        private double america;
        private double euro;
        private double britishPound;
        private double yen;
        private double won;

        public Transfer()
        {
            yuan = 0;
            rupee = 0;
            egypt = 0;
            france = 0;
            brazil = 0;
            argentine = 0;
            Saudi = 0;
            canada = 0;
            america = 0;
            euro = 0;
            britishPound = 0;
            yen = 0;
            won = 0;
        }


        //Copy constructor
        public Transfer(Transfer transfer)
        {
            transfer.yuan = this.yuan;
            transfer.rupee = this.rupee;
            transfer.egypt = this.egypt;
            transfer.france = this.france;
            transfer.brazil = this.brazil;
            transfer.argentine = this.argentine;
            transfer.Saudi = this.Saudi;
            transfer.canada = this.canada;
            transfer.america = this.america;
            transfer.euro = this.euro;
            transfer.britishPound = this.britishPound;
            transfer.yen = this.yen;
            transfer.won = this.won;

        }

        //Accessors
        public Double getCanada()
        {
            double something = canada;
            something = (double)Math.Round(something * 10000) / 10000;
            return something;
        }

        public Double getAmerica()
        {
            double something = america;
            something = (double) Math.Round(something * 10000) / 10000;
            return something;
        }

        public Double getYen()
        {
            double something = yen;
            something = (double)Math.Round(something * 10000) / 10000;
            return something;
        }

        public Double getWon()
        {
            double something = won;
            something = (double)Math.Round(something * 10000) / 10000;
            return something;
        }

        //Mutators
        public void setCanada(double x)
        {
            canada = x;
        }
        public void setAmerica(double y)
        {
            america = y;
        }
        public void setYen(double w)
        {
            yen = w;
        }
        public void setWon(double z)
        {
            won = z;
        }

        //ALL METHODS
        public Double fromCanada()
        {
            double something = canada;

            america = 0.74 * something;
            yen = 98.90 * something;
            won = 942.65 * something;

            return something;
        }

        public Double fromAmerica()
        {
            double something = america;

            canada = 1.35 * something;
            yen = 133.50 * something;
            won = 1272.73 * something;

            return something;
        }

        public Double fromJapan()
        {
            double something = yen;

            won = 9.53 * something;
            america = 0.0075 * something;
            canada = 0.010 * something;

            return something;
        }

        public Double fromKorea()
        {
            double something = won;

            canada = 0.0011 * something;
            america = 0.00079 * something;
            yen = 0.10 * something;

            return something;
        }
    }
}
