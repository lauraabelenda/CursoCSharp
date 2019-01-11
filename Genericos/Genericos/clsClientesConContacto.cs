﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class clsClientesConContacto : clsClientesBase
    {
        public clsClientesConContacto()
        {
            _Direccion = new clsDirecciones();

        }
        public clsClientesConContacto(int pId, string pNombre, string pClave,
                                        string pRFC, int pTipoRegimen,
                                        string pNombreContacto, string pTelefono1,
                                        string pTelefono2, string pEmail,
                                        string pCalle, string pNumeroExterior,
                                        string pNumeroInterior, string pColonia,
                                        string pMunicipio, string pEstado,
                                        string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            _Direccion = new clsDirecciones();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.Estado = pEstado;
            Direccion.CP = pCP;

        }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }
        public clsDirecciones Direccion { get => _Direccion; set => _Direccion = value; }

        private clsDirecciones _Direccion;


    }
}
