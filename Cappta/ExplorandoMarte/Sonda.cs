using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoMarte
{
    public class Sonda
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direcao { get; private set; }

        public Sonda(int x, int y, char direcao)
        {
            X = x;
            Y = y;
            Direcao = direcao;
        }

        public void Mover(char instrucao, int maxX, int maxY)
        {
            if (instrucao == 'L')
                GirarEsquerda();
            else if (instrucao == 'R')
                GirarDireita();
            else if (instrucao == 'M')
                MoverFrente(maxX, maxY);
        }
        private void GirarEsquerda()
        {
            switch (Direcao)
            {
                case 'N': Direcao = 'W';
                    break;
                case 'W': Direcao = 'S';
                    break;
                case 'S': Direcao = 'E';
                    break;
                case 'E': Direcao = 'N';
                    break;
            }
        }

        private void GirarDireita()
        {
            switch (Direcao)
            {
                case 'N': Direcao = 'E';
                    break;
                case 'E': Direcao = 'S';
                    break;
                case 'S': Direcao = 'W';
                    break;
                case 'W': Direcao = 'N';
                    break;
            }
        }

        private void MoverFrente(int maxX, int maxY)
        {
            switch (Direcao)
            {
                case 'N':
                    if (Y < maxY) Y++;
                    break;
                case 'E':
                    if (X < maxX) X++;
                    break;
                case 'S':
                    if (Y > 0) Y--;
                    break;
                case 'W':
                    if (X > 0) X--;
                    break;
            }
        }

    }
}
