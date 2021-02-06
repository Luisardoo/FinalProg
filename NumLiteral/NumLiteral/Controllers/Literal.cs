using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumLiteral.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //  EN EL BUSCADOR ->  api/Literal?n=   luego del '=' se coloca el número
    public class Literal : Controller
    {
        private string Millones(char n)
        {
            if (n == '1')
            { return "Un millon "; }
            if (n == '2')
            { return "Dos millones "; }
            if (n == '3')
            { return "Tres millones "; }
            if (n == '4')
            { return "Cuatro millones "; }
            if (n == '5')
            { return "Cinco millones "; }
            if (n == '6')
            { return "Seis millones "; }
            if (n == '7')
            { return "Siete millones "; }
            if (n == '8')
            { return "Ocho millones "; }
            return "Nueve millones ";
        }

        private string Cientos(char n)
        {
            if (n == '0')
            { return " "; }
            if (n == '1')
            { return "Ciento "; }
            if (n == '2')
            { return "Doscientos "; }
            if (n == '3')
            { return "Trescientos "; }
            if (n == '4')
            { return "Cuatrocientos "; }
            if (n == '5')
            { return "Quinientos "; }
            if (n == '6')
            { return "Seiscientos "; }
            if (n == '7')
            { return "Setecientos "; }
            if (n == '8')
            { return "Ochocientos "; }
            return "Novecientos ";
        }

        private string Decenas(char n)
        {
            if (n == '0')
            { return " "; }
            if (n == '1')
            { return "Diez "; }
            if (n == '2')
            { return "Veinte "; }
            if (n == '3')
            { return "Treinta "; }
            if (n == '4')
            { return "Cuarenta "; }
            if (n == '5')
            { return "Cincuenta "; }
            if (n == '6')
            { return "Sesenta "; }
            if (n == '7')
            { return "Setenta "; }
            if (n == '8')
            { return "Ochenta "; }
            return "Noventa ";
        }

        private string Unidades(char n)
        {
            if (n == '0')
            { return " "; }
            if (n == '1')
            { return "Uno "; }
            if (n == '2')
            { return "Dos "; }
            if (n == '3')
            { return "Tres "; }
            if (n == '4')
            { return "Cuatro "; }
            if (n == '5')
            { return "Cinco "; }
            if (n == '6')
            { return "Seis "; }
            if (n == '7')
            { return "Siete "; }
            if (n == '8')
            { return "Ocho "; }
            return "Nueve ";
        }

        private string Especiales(char n)
        {
            if (n == '0')
            { return " "; }
            if (n == '1')
            { return "Once "; }
            if (n == '2')
            { return "Doce "; }
            if (n == '3')
            { return "Trece "; }
            if (n == '4')
            { return "Catorce "; }
            if (n == '5')
            { return "Quince "; }
            if (n == '6')
            { return "Dieciseis "; }
            if (n == '7')
            { return "Diecisiete "; }
            if (n == '8')
            { return "Dieciocho "; }
            return "Diecinueve ";
        }

        // Comienza GET

        [HttpGet]
        public string NumGet(string n)
        {
            string respuesta = "";
            if (n.Length > 7)
            { return "Numero mayor a 7 digitos"; }
            if (n.Length < 1)
            { return "Ningun numero digitado"; }
            if (n.Length == 7)
            {
                respuesta += Millones(n[0]);
                respuesta += Cientos(n[1]);
                if (n[2] == '1' && n[3] == '1' || n[2] == '1' && n[3] == '2' || n[2] == '1' && n[3] == '3'
                 || n[2] == '1' && n[3] == '4' || n[2] == '1' && n[3] == '5' || n[2] == '1' && n[3] == '6'
                 || n[2] == '1' && n[3] == '7' || n[2] == '1' && n[3] == '8' || n[2] == '1' && n[3] == '9')
                {
                    respuesta += Especiales(n[3]);
                    respuesta += "mil ";
                }
                else
                {
                    respuesta += Decenas(n[2]);
                    if (n[2] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[3]);
                    if (n[3] != '0')
                    {
                        respuesta += "mil ";
                    }
                }

                respuesta += Cientos(n[4]);
                if (n[5] == '1' && n[6] == '1' || n[5] == '1' && n[6] == '2' || n[5] == '1' && n[6] == '3'
                 || n[5] == '1' && n[6] == '4' || n[5] == '1' && n[6] == '5' || n[5] == '1' && n[6] == '6'
                 || n[5] == '1' && n[6] == '7' || n[5] == '1' && n[6] == '8' || n[5] == '1' && n[6] == '9')
                {
                    respuesta += Especiales(n[6]);
                }
                else
                {
                    respuesta += Decenas(n[5]);
                    if (n[5] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[6]);
                }
            } // Termina 7 dígitos


            if (n.Length == 6)
            {
                respuesta += Cientos(n[0]);
                if (n[1] == '1' && n[2] == '1' || n[1] == '1' && n[2] == '2' || n[1] == '1' && n[2] == '3'
                 || n[1] == '1' && n[2] == '4' || n[1] == '1' && n[2] == '5' || n[1] == '1' && n[2] == '6'
                 || n[1] == '1' && n[2] == '7' || n[1] == '1' && n[2] == '8' || n[1] == '1' && n[2] == '9')
                {
                    respuesta += Especiales(n[2]);
                    respuesta += "mil ";
                }
                else
                {
                    respuesta += Decenas(n[1]);
                    if (n[1] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[2]);
                        respuesta += "mil ";
                    
                    
                }

                respuesta += Cientos(n[3]);
                if (n[4] == '1' && n[5] == '1' || n[4] == '1' && n[5] == '2' || n[4] == '1' && n[5] == '3'
                 || n[4] == '1' && n[5] == '4' || n[4] == '1' && n[5] == '5' || n[4] == '1' && n[5] == '6'
                 || n[4] == '1' && n[5] == '7' || n[4] == '1' && n[5] == '8' || n[4] == '1' && n[5] == '9')
                {
                    respuesta += Especiales(n[5]);
                }
                else
                {
                    respuesta += Decenas(n[4]);
                    if (n[5] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[5]);
                }
            }// Termina 6 dígitos

            if (n.Length == 5)
            {

                if (n[0] == '1' && n[1] == '1' || n[0] == '1' && n[1] == '2' || n[0] == '1' && n[1] == '3'
                 || n[0] == '1' && n[1] == '4' || n[0] == '1' && n[1] == '5' || n[0] == '1' && n[1] == '6'
                 || n[0] == '1' && n[1] == '7' || n[0] == '1' && n[1] == '8' || n[0] == '1' && n[1] == '9')
                {
                    respuesta += Especiales(n[1]);
                    respuesta += "mil ";
                }
                else
                {
                    respuesta += Decenas(n[0]);
                    respuesta += "y ";
                    respuesta += Unidades(n[1]);
                    respuesta += "mil ";
                }

                respuesta += Cientos(n[2]);
                if (n[3] == '1' && n[4] == '1' || n[3] == '1' && n[4] == '2' || n[3] == '1' && n[4] == '3'
                 || n[3] == '1' && n[4] == '4' || n[3] == '1' && n[4] == '5' || n[3] == '1' && n[4] == '6'
                 || n[3] == '1' && n[4] == '7' || n[3] == '1' && n[4] == '8' || n[3] == '1' && n[4] == '9')
                {
                    respuesta += Especiales(n[4]);
                }
                else
                {
                    respuesta += Decenas(n[3]);
                    if (n[4] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[4]);
                }
            }// Termina 5 dígitos


            if (n.Length == 4)
            {
                respuesta += Unidades(n[0]);
                if (n[0] != '0')
                {
                    respuesta += "mil ";
                }

                respuesta += Cientos(n[1]);
                if (n[2] == '1' && n[3] == '1' || n[2] == '1' && n[3] == '2' || n[2] == '1' && n[3] == '3'
                 || n[2] == '1' && n[3] == '4' || n[2] == '1' && n[3] == '5' || n[2] == '1' && n[3] == '6'
                 || n[2] == '1' && n[3] == '7' || n[2] == '1' && n[3] == '8' || n[2] == '1' && n[3] == '9')
                {
                    respuesta += Especiales(n[3]);
                }
                else
                {
                    respuesta += Decenas(n[2]);
                    if (n[3] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[3]);
                }
            }// Termina 4 dígitos

            if (n.Length == 3)
            {
                respuesta += Cientos(n[0]);
                if (n[1] == '1' && n[2] == '1' || n[1] == '1' && n[2] == '2' || n[1] == '1' && n[2] == '3'
                 || n[1] == '1' && n[2] == '4' || n[1] == '1' && n[2] == '5' || n[1] == '1' && n[2] == '6'
                 || n[1] == '1' && n[2] == '7' || n[1] == '1' && n[2] == '8' || n[1] == '1' && n[2] == '9')
                {
                    respuesta += Especiales(n[2]);
                }
                else
                {
                    respuesta += Decenas(n[1]);
                    if (n[2] != '0')
                    {
                        respuesta += "y ";
                    }
                    respuesta += Unidades(n[2]);
                }
            }// Termina 3 dígitos

            if (n.Length == 2)
            {

                if (n[0] < '0')
                {
                    respuesta += "menos ";
                    respuesta += Unidades(n[1]);
                }
                else
                {

                    if (n[0] == '1' && n[1] == '1' || n[0] == '1' && n[1] == '2' || n[0] == '1' && n[1] == '3'
                     || n[0] == '1' && n[1] == '4' || n[0] == '1' && n[1] == '5' || n[0] == '1' && n[1] == '6'
                     || n[0] == '1' && n[1] == '7' || n[0] == '1' && n[1] == '8' || n[0] == '1' && n[1] == '9')
                    {
                        respuesta += Especiales(n[1]);
                    }
                    else
                    {
                        respuesta += Decenas(n[0]);
                        if (n[1] != '0')
                        {
                            respuesta += "y ";
                        }
                        respuesta += Unidades(n[1]);
                    }
                }
            }// Termina 2 dígitos

            if (n.Length == 1)
            { 
                respuesta += Unidades(n[0]);
                if(n[0] == '0')
                {
                    respuesta += "Cero";
                }    


            }// Termina 1 dígitos
            return respuesta;
        }

    } //Fin del Literal:Controller
} // Fin del programa completo
