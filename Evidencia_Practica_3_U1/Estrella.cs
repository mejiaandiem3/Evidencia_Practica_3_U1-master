using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia_Practica_3_U1
{
    class Estrella
    {

        SolidBrush Relleno;
        Rectangle rect;
        int vertices=5;
        
        public int Vertices { get => vertices; set => vertices = value; }

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Estrella(int puntos = 5) 
        {
        
        }

        /// <summary>
        /// Crea los limites en base a un rectangulo,(tambien se pueden incluir las coordenadas)
        /// </summary>
        /// <param name="limites">Limites y coodenadas de la estrella</param>
        public Estrella(Rectangle limites) 
        {
            this.rect = limites;
        }

        /// <summary>
        /// Crea los limites en base a un rectangulo, establece el relleno
        /// </summary>
        /// <param name="limites">Limites y coodenadas de la estrella</param>
        /// <param name="relleno">Color de relleno de la estrella</param>
        public Estrella(Rectangle limites, Color relleno) 
        {
            this.rect = limites;
            this.Relleno = new SolidBrush(relleno);
        }

        /// <summary>
        /// Crea el tamaño de la estrella
        /// </summary>
        /// <param name="ancho">Limites (ancho)</param>
        /// <param name="alto">Limites (alto)</param>
        public Estrella(int ancho, int alto)
        {
            rect.Width = ancho;
            rect.Height = alto;
        }
        

        /// <summary>
        /// Crea las coordenadas de la estrella en base a un Objeto del tipo "Point"
        /// </summary>
        /// <param name="ubicacion"></param>
        public Estrella(Point ubicacion)
        {
            rect.X = ubicacion.X;
            rect.Y = ubicacion.Y;
        }

        /// <summary>
        /// Crea el tamaño de la estrella, y establece su color de relleno
        /// </summary>
        /// <param name="ancho">Limites (ancho)</param>
        /// <param name="alto">Limites (alto)</param>
        /// <param name="relleno">Color de relleno de la estrella</param>
        public Estrella(int ancho, int alto, Color relleno)
        {
            rect.Width = ancho;
            rect.Height = alto;
            Relleno = new SolidBrush(relleno);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Coordenada en X de la estrella</param>
        /// <param name="y">Coordenada en Y de la estrella</param>
        /// <param name="ancho">Limites (ancho)</param>
        /// <param name="alto">Limites (alto)</param>
        /// <param name="relleno">Color de relleno de la estrella</param>
        public Estrella(int x, int y, int ancho, int alto, Color relleno)
        {
            rect.Width = ancho;
            rect.Height = alto;
            rect.X = x;
            rect.Y = y;
            Relleno = new SolidBrush(relleno);
        }

        #endregion

        #region CambiarPropiedades

        /// <summary>
        /// Cambia el tamaño de la estrella
        /// </summary>
        /// <param name="ancho">Limites (ancho)</param>
        /// <param name="alto">Limites (alto)</param>
        public void CambiarTamaño(int ancho, int alto)
        {
            rect.Width = ancho;
            rect.Height = alto;
        }

        /// <summary>
        /// Cambia el relleno de la estrella
        /// </summary>
        /// <param name="relleno">Color de relleno de la estrella</param>
        public void CambiarRelleno(Color relleno)
        {
            Relleno = new SolidBrush(relleno);
        }

        /// <summary>
        /// Cambia las coordenadas de la estrella
        /// </summary>
        /// <param name="x">Coordenada en X</param>
        /// <param name="y">Coordenada en Y</param>
        public void CambiarCoordenadas(int x, int y)
        {
            rect.X = x;
            rect.Y = y;
        }
        
        /// <summary>
        /// Cambia la cantidad de puntos de la estrella
        /// </summary>
        /// <param name="puntos">Cantidad de puntos de la estrella</param>
        public void CambiarPuntos(int puntos)
        {
            this.vertices = puntos;
        }

        #endregion

        // Draw the indicated star in the rectangle.
        static public void DibujarEstrella(Graphics gr, Estrella estrella, int skip)
        {
            // Obtiene los puntos de la estrella
            PointF[] puntos = CrearPuntos(-Math.PI / 2, estrella.Vertices, skip, estrella.rect);

            // Dibuja la estrella
            gr.FillPolygon(estrella.Relleno, puntos);
        }


        // Generate the points for a star.
        static private PointF[] CrearPuntos(double teta_estrella, int puntos, int concav, Rectangle rectangulo)
        {
            double teta, dteta;
            PointF[] resultado;
            float rx = rectangulo.Width / 2f;
            float ry = rectangulo.Height / 2f;
            float cx = rectangulo.X + rx;
            float cy = rectangulo.Y + ry;

            //Si es un poligono, no busca concavidad
            if (concav == 1)
            {
                resultado = new PointF[puntos];
                teta = teta_estrella;
                dteta = 2 * Math.PI / puntos;
                for (int i = 0; i < puntos; i++)
                {
                    resultado[i] = new PointF(
                        (float)(cx + rx * Math.Cos(teta)),
                        (float)(cy + ry * Math.Sin(teta)));
                    teta += dteta;
                }
                return resultado;
            }

            //Radio para los vertices concavos.
            double radioConvav = CalcularRConcavo(puntos, concav);

            //Crea los puntos
            resultado = new PointF[2 * puntos];
            teta = teta_estrella;
            dteta = Math.PI / puntos;
            for (int i = 0; i < puntos; i++)
            {
                resultado[2 * i] = new PointF(
                    (float)(cx + rx * Math.Cos(teta)),
                    (float)(cy + ry * Math.Sin(teta)));
                teta += dteta;
                resultado[2 * i + 1] = new PointF(
                    (float)(cx + rx * Math.Cos(teta) * radioConvav),
                    (float)(cy + ry * Math.Sin(teta) * radioConvav));
                teta += dteta;
            }
            return resultado;
        }

        // Calculate the inner star radius.
        static private double CalcularRConcavo(int puntos, int skip)
        {
            // For really small numbers of points.
            if (puntos < 5) return 0.33f;

            // Calculate angles to key points.
            double dteta = 2 * Math.PI / puntos;
            double teta00 = -Math.PI / 2;
            double teta01 = teta00 + dteta * skip;
            double teta10 = teta00 + dteta;
            double teta11 = teta10 - dteta * skip;

            // Find the key points.
            PointF pt00 = new PointF(
                (float)Math.Cos(teta00),
                (float)Math.Sin(teta00));
            PointF pt01 = new PointF(
                (float)Math.Cos(teta01),
                (float)Math.Sin(teta01));
            PointF pt10 = new PointF(
                (float)Math.Cos(teta10),
                (float)Math.Sin(teta10));
            PointF pt11 = new PointF(
                (float)Math.Cos(teta11),
                (float)Math.Sin(teta11));

            // See where the segments connecting the points intersect.
            bool lines_intersect, segments_intersect;
            PointF intersection, close_p1, close_p2;
            Interseccion(pt00, pt01, pt10, pt11,
                out lines_intersect, out segments_intersect,
                out intersection, out close_p1, out close_p2);

            // Calculate the distance between the
            // point of intersection and the center.
            return Math.Sqrt(
                intersection.X * intersection.X +
                intersection.Y * intersection.Y);
        }

        // Find the point of intersection between
        // the lines p1 --> p2 and p3 --> p4.
        static private void Interseccion(
            PointF p1, PointF p2, PointF p3, PointF p4,
            out bool lines_intersect, out bool segments_intersect,
            out PointF intersection,
            out PointF close_p1, out PointF close_p2)
        {
            // Get the segments' parameters.
            float dx12 = p2.X - p1.X;
            float dy12 = p2.Y - p1.Y;
            float dx34 = p4.X - p3.X;
            float dy34 = p4.Y - p3.Y;

            // Solve for t1 and t2
            float denominator = (dy12 * dx34 - dx12 * dy34);

            float t1 =
                ((p1.X - p3.X) * dy34 + (p3.Y - p1.Y) * dx34)
                    / denominator;
            if (float.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                lines_intersect = false;
                segments_intersect = false;
                intersection = new PointF(float.NaN, float.NaN);
                close_p1 = new PointF(float.NaN, float.NaN);
                close_p2 = new PointF(float.NaN, float.NaN);
                return;
            }
            lines_intersect = true;

            float t2 =
                ((p3.X - p1.X) * dy12 + (p1.Y - p3.Y) * dx12)
                    / -denominator;

            // Find the point of intersection.
            intersection = new PointF(p1.X + dx12 * t1, p1.Y + dy12 * t1);

            // The segments intersect if t1 and t2 are between 0 and 1.
            segments_intersect =
                ((t1 >= 0) && (t1 <= 1) &&
                 (t2 >= 0) && (t2 <= 1));

            // Find the closest points on the segments.
            if (t1 < 0)
                t1 = 0;
            else if (t1 > 1)
                t1 = 1;

            if (t2 < 0)
                t2 = 0;
            else if (t2 > 1)
                t2 = 1;

            close_p1 = new PointF(p1.X + dx12 * t1, p1.Y + dy12 * t1);
            close_p2 = new PointF(p3.X + dx34 * t2, p3.Y + dy34 * t2);
        }


    }
}
