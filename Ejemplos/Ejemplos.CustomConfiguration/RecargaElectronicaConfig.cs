using System;
namespace Ejemplos.CustomConfiguration
{
    public class RecargaElectronicaConfig
    {
        private string codigo;
        private string proveedor;
        private int codigoConvenio;
        private string idEmpresa;
        private string idServicio;
        private string idCriterioBusqueda;
        private int reintentos;
        public string Codigo { get => codigo; set => codigo = value ?? throw new ArgumentNullException("Codigo"); }
        public string Proveedor { get => proveedor; set => proveedor = value ?? throw new ArgumentNullException("Proveedor"); }
        public int CodigoConvenio { get => codigoConvenio; set => codigoConvenio = value >= 0 ? value : throw new ArgumentOutOfRangeException("CodigoConvenio", value, "Valor no puede ser un numero negativo"); }
        public string IdEmpresa { get => idEmpresa; set => idEmpresa = value ?? throw new ArgumentNullException("IdEmpresa"); }
        public string IdServicio { get => idServicio; set => idServicio = value ?? throw new ArgumentNullException("IdServicio"); }
        public string IdCriterioBusqueda { get => idCriterioBusqueda; set => idCriterioBusqueda = value ?? throw new ArgumentNullException("IdCriterioBusqueda"); }
        public int Reintentos { get => reintentos; set => reintentos = value >= 0 ? value : throw new ArgumentOutOfRangeException("Reintentos", value, "Valor no puede ser un numero negativo"); }
    }
}
