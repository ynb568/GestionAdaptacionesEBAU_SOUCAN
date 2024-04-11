﻿namespace CapaEntidad
{
    public class Direccion
    {
        public int IdDireccion {  get; set; }
        public string NombreDireccion { get; set; }
        public Municipio Municipio { get; set; }
        
        public string DisplayValue
        {
            get
            {
                return $"{NombreDireccion} ({Municipio.NombreMunicipio})";
            }
        }
    }
}
