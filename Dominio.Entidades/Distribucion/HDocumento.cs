using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio.Entidades.Distribucion
{
    public class HDocumento
    {
        [Key]
        public int codi_cab { get; set; }
        public string esta_pod { get; set; }
        public string codi_caja { get; set; }
        public string comp { get; set; }
        public string serie { get; set; }
        public string nume { get; set; }
        public DateTime? fecha { get; set; }
        public string codi_vend { get; set; }
        public string clie_docu { get; set; }
        public string clie_nomb { get; set; }
        public string clie_dire { get; set; }
        public string clie_email { get; set; }
        public string clie_celu { get; set; }
        public string dire_entr { get; set; }
        public string ubig_entr { get; set; }
        public string mone_codi { get; set; }
        public string LLEVAigv { get; set; }
        public string desc_globa { get; set; }
        public string obse { get; set; }
        public string guia { get; set; }
        public string placa { get; set; }
        public string dire_part { get; set; }
        public string ubig_part { get; set; }
        public string ubig_lleg { get; set; }
        public string cod_Ubigeo { get; set; }
        public string tipo_trans { get; set; }
        public decimal? peso_kg { get; set; }
        public string trans_publ_ruc { get; set; }
        public string trans_publ_razon { get; set; }
        public string trans_priv_placa { get; set; }
        public string trans_priv_marca { get; set; }
        public string trans_priv_const { get; set; }
        public string trans_priv_lice { get; set; }
        public string codi_moti { get; set; }
        public string motivo { get; set; }
        public string doc_refe { get; set; }
        public string ValorResumen { get; set; }
        public string ValorHash { get; set; }
        public string DarBaja { get; set; }
        public string MotivoBaja { get; set; }
        public string ProcesarBaja { get; set; }
        public decimal? Grabado { get; set; }
        public decimal? IGV { get; set; }
        public decimal? Total { get; set; }
        public string dire_lleg { get; set; }
        public string Guia_trans { get; set; }
        public string Envio_xml { get; set; }
        public string Clie_tipo { get; set; }
        public string Fact_guia { get; set; }
        public decimal? Inafecto { get; set; }
        public decimal? Exonerado { get; set; }
        public decimal? percepcion { get; set; }
        public string Codigo_local { get; set; }
        public string hora { get; set; }
        public string Forma_pago { get; set; }
        public decimal? total_credito { get; set; }
    }
}
