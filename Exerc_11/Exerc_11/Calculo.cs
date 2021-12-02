using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_11
{
    class Calculo
    {
        #region atributos
        private double num1;
        private double num2;
        private double resultado;
        private double Abaixo;
        private double Ideal;
        private double Acima;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Calculo(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }

        public double getNum1()
        {
            return this.num1;
        }

        public double getNum2()
        {
            return this.num2;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        public bool getAbaixo()
        {
            return (this.resultado == Abaixo);
        }
        public bool getIdeal()
        {
            return (this.resultado == Ideal);
        }
        public bool getAcima()
        {
            return (this.resultado == Acima);
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado = this.num1 / (this.num2 * this.num2);

           if (resultado < 20)
            {
                this.Abaixo = this.resultado;
            }
            if (20 <= resultado)
            {
                if (25 > resultado)
                {
                    this.Ideal = this.resultado;
                }
            }
            if (resultado >= 25)
            {
                this.Acima = this.resultado; 
            }
        }
        #endregion
    }
}
