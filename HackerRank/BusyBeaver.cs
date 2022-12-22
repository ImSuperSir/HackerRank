using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HackerRank
{
    
    public class Dimension
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Dimension(int horizontal, int vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        public Dimension()
        {

        }

    }
    
    public class Coordenada
    {

        public Coordenada(int pHorizontal, int pVertical, int pvalue)
        {
            Horizontal = pHorizontal;
            Vertical = pVertical;
            Value = pvalue;
        }
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public int Value { get; set; }
    }
    public class Square
    {

        List<Coordenada> _Coordenadas;
        //Dimension _Dimension;

        int[,] _Matrix;
        public Dimension _Dimension { get; set; } //= new Dimension();

        public Coordenada _CoordenadaInicial { get; set; }
        public Coordenada _CoordenadaActual { get; set; }

        public Square(List<List<int>> pforest)
        {
            _Dimension = new Dimension();
            Initializer(pforest);
        }



        /// <summary>
        /// To print represented values
        /// </summary>
        private void PrintMatriz()
        {

            for (int vertical = 0; vertical < _Dimension.Vertical; vertical++)
            {
                for (int horizontal = 0; horizontal < _Dimension.Horizontal; horizontal++)
                {
                    //_Matrix[vertical, horizontal] = pforest[vertical][horizontal];
                    Debug.Write($" {_Matrix[horizontal, vertical]},");

                }
                Debug.Write($"\n");
            }
        }


        private void Initializer(List<List<int>> pforest) 
        {
            _Dimension.Horizontal = pforest[0].Count; //es cuadratica, todos son iguales en longitud
            _Dimension.Vertical = pforest.Count;

            _Matrix = new int[_Dimension.Horizontal, _Dimension.Vertical];

            for (int vertical = 0; vertical < _Dimension.Vertical; vertical++)
            {
                for (int horizontal = 0; horizontal < _Dimension.Horizontal; horizontal++)
                {
                    _Matrix[horizontal,vertical] = pforest[vertical][horizontal];
                }
            }

            PrintMatriz();

            List<int> centerHorizontales = new List<int>();
            List<int> centerVerticales = new List<int>();

            if (_Dimension.Horizontal % 2 == 1)
            {
                centerHorizontales.Add((_Dimension.Horizontal / 2) + 1);
            }
            else
            {   //has two options, 
                centerHorizontales.Add((_Dimension.Horizontal / 2));
                centerHorizontales.Add((_Dimension.Horizontal / 2) + 1);
            }

            if (_Dimension.Vertical % 2 == 1)
            {
                centerVerticales.Add((_Dimension.Vertical / 2) + 1);
            }
            else
            {   //has two options, 
                centerVerticales.Add((_Dimension.Vertical / 2));
                centerVerticales.Add((_Dimension.Vertical / 2) + 1);
            }

            List<Coordenada> lCoordenadasCandidatas = new List<Coordenada>();

            for (int horizontal = 0; horizontal < centerHorizontales.Count; horizontal++)
            {
                for (int vertical = 0; vertical < centerVerticales.Count; vertical++)
                {
                    Coordenada lNewCoordenada = new Coordenada(centerHorizontales[horizontal]-1, centerVerticales[vertical]-1, _Matrix[centerHorizontales[horizontal] - 1, centerVerticales[vertical] - 1]);
                    lCoordenadasCandidatas.Add(lNewCoordenada);
                }
            }


            _CoordenadaInicial = lCoordenadasCandidatas.OrderByDescending(s => s.Value).ToList().First(); // .Where(x => Max(x.Value))

            _CoordenadaActual = _CoordenadaInicial; // por default
        }



        private Coordenada? CoordenadaUp
        {
            get 
            {
                int lx = _CoordenadaActual.Horizontal;
                int ly = _CoordenadaActual.Vertical;

                if(  ly - 1 >= 0)
                     return new Coordenada(lx, ly - 1, _Matrix[lx,ly-1]);
                else
                    return null;
            } 
        }

        private Coordenada? CoordenadaDown
        {
            get
            {
                int lx = _CoordenadaActual.Horizontal;
                int ly = _CoordenadaActual.Vertical;

                if (ly + 1  <= _Dimension.Vertical - 1 )
                    return new Coordenada(lx, ly + 1, _Matrix[lx, ly + 1]);
                else
                    return null;
            }
        }


        private Coordenada? CoordenadaLeft
        {
            get
            {
                int lx = _CoordenadaActual.Horizontal;
                int ly = _CoordenadaActual.Vertical;

                if (lx - 1 >= 0)
                    return new Coordenada(lx -1, ly , _Matrix[lx -1, ly]);
                else
                    return null;
            }
        }

        private Coordenada? CoordenadaRight
        {
            get
            {
                int lx = _CoordenadaActual.Horizontal;
                int ly = _CoordenadaActual.Vertical;

                if (lx + 1 <= _Dimension.Horizontal - 1)
                    return new Coordenada(lx + 1, ly , _Matrix[lx + 1, ly]);
                else
                    return null;
            }
        }

        public Coordenada? GetNextCoordenada()
        {
            Debug.WriteLine($" - { CoordenadaUp?.Value }  - ");
            Debug.WriteLine($" {CoordenadaLeft?.Value} {_CoordenadaActual.Value}  {CoordenadaRight?.Value} ");
            Debug.WriteLine($" - {CoordenadaDown?.Value}  - ");

            List<Coordenada> result = new List<Coordenada>();

            if (CoordenadaUp != null && CoordenadaUp.Value > 0)
                result.Add(CoordenadaUp);
            if (CoordenadaRight != null && CoordenadaRight.Value > 0)
                result.Add(CoordenadaRight);
            if (CoordenadaLeft != null && CoordenadaLeft.Value > 0  ) 
                result.Add ( CoordenadaLeft);
            if (CoordenadaDown != null && CoordenadaDown.Value > 0 )
                result.Add(CoordenadaDown);

            Coordenada lNext = result.OrderByDescending( s => s.Value).ToList().FirstOrDefault();
            
            Debug.WriteLine($" hor:{lNext?.Horizontal},vert:{lNext?.Vertical} Value: {lNext?.Value} ");
            return lNext;
        }

        


        public int GetLogsFromForest()
        {

            Coordenada coordenada = _CoordenadaInicial;
            int lAccumulatedLogs = 0;

            lAccumulatedLogs = _CoordenadaActual.Value;
            _Matrix[_CoordenadaActual.Horizontal, _CoordenadaActual.Vertical] = 0;
            PrintMatriz();
            do
            {
                _CoordenadaActual = GetNextCoordenada();
                lAccumulatedLogs += _CoordenadaActual == null ? 0 : _CoordenadaActual.Value;

                if (null != _CoordenadaActual)
                {
                    _Matrix[_CoordenadaActual.Horizontal, _CoordenadaActual.Vertical] = 0;
                    PrintMatriz();
                }

            } while(null != _CoordenadaActual);

            return lAccumulatedLogs;
        }
          
    }

}
