﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatafirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NARGESTEntities : DbContext
    {
        public NARGESTEntities()
            : base("name=NARGESTEntities")
        {
    	     Database.CommandTimeout = 5000;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VENTA_X_COBRAR> VENTA_X_COBRAR { get; set; }
        public virtual DbSet<VENTADET> VENTADET { get; set; }
        public virtual DbSet<VENDEDOR> VENDEDOR { get; set; }
        public virtual DbSet<TIPOPROD> TIPOPROD { get; set; }
        public virtual DbSet<TIPODOC> TIPODOC { get; set; }
        public virtual DbSet<VENTACAB> VENTACAB { get; set; }
        public virtual DbSet<TMP_PEDIDO_XVENDEDOR> TMP_PEDIDO_XVENDEDOR { get; set; }
        public virtual DbSet<CIUDAD> CIUDAD { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<TIPOPRE> TIPOPRE { get; set; }
        public virtual DbSet<RUTA> RUTA { get; set; }
        public virtual DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<TIPCREDF> TIPCREDF { get; set; }
        public virtual DbSet<ALMACEN> ALMACEN { get; set; }
        public virtual DbSet<CATEGORIA_CLIENTE> CATEGORIA_CLIENTE { get; set; }
        public virtual DbSet<SEGMENTO_CLIENTE> SEGMENTO_CLIENTE { get; set; }
        public virtual DbSet<TIPONEGOCIO> TIPONEGOCIO { get; set; }
        public virtual DbSet<paisdepa> paisdepa { get; set; }
        public virtual DbSet<CLIE_FUERZA> CLIE_FUERZA { get; set; }
        public virtual DbSet<FUERZAVENTA> FUERZAVENTA { get; set; }
        public virtual DbSet<CONFIGSIS> CONFIGSIS { get; set; }
        public virtual DbSet<CONFIGVTA> CONFIGVTA { get; set; }
        public virtual DbSet<ACCESO> ACCESO { get; set; }
        public virtual DbSet<CIERRE_MES_INVENTARIO> CIERRE_MES_INVENTARIO { get; set; }
        public virtual DbSet<ACCESOPROC> ACCESOPROC { get; set; }
        public virtual DbSet<ACTIVO> ACTIVO { get; set; }
        public virtual DbSet<rsyssegment> rsyssegment { get; set; }
        public virtual DbSet<rsyssegmentC> rsyssegmentC { get; set; }
        public virtual DbSet<syssegments> syssegments { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<CLIDEP> CLIDEP { get; set; }
        public virtual DbSet<ACTIVO_FIJO> ACTIVO_FIJO { get; set; }
        public virtual DbSet<ALMAZON> ALMAZON { get; set; }
        public virtual DbSet<ADUANA> ADUANA { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
        public virtual DbSet<TipoPrecioXPromocion> TipoPrecioXPromocions { get; set; }
        public virtual DbSet<TipoPagoXPromocion> TipoPagoXPromocions { get; set; }
        public virtual DbSet<TMP_STOCKPEDIDO> TMP_STOCKPEDIDO { get; set; }
        public virtual DbSet<ARTIDAT> ARTIDATs { get; set; }
        public virtual DbSet<TipoPagoXPromocionSub> TipoPagoXPromocionSubs { get; set; }
        public virtual DbSet<CLIENTEXPROMOSUBCAT> CLIENTEXPROMOSUBCATs { get; set; }
        public virtual DbSet<TipoPrecioXPromocionSubCat> TipoPrecioXPromocionSubCats { get; set; }
        public virtual DbSet<LINEA> LINEAs { get; set; }
        public virtual DbSet<SUBLINEA> SUBLINEAs { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
    
        public virtual int SP_INSERT_TMP_VENDEDOR(Nullable<int> cORREL, string cODVEND)
        {
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            var cODVENDParameter = cODVEND != null ?
                new ObjectParameter("CODVEND", cODVEND) :
                new ObjectParameter("CODVEND", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERT_TMP_VENDEDOR", cORRELParameter, cODVENDParameter);
        }
    
        public virtual int SP_DELETE_TMP_VENDEDOR(string cORREL)
        {
            var cORRELParameter = cORREL != null ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_TMP_VENDEDOR", cORRELParameter);
        }
    
        public virtual ObjectResult<SP_SELECT_FACTURAS_Result> SP_SELECT_FACTURAS(string fECHA1, string fECHA2)
        {
            var fECHA1Parameter = fECHA1 != null ?
                new ObjectParameter("FECHA1", fECHA1) :
                new ObjectParameter("FECHA1", typeof(string));
    
            var fECHA2Parameter = fECHA2 != null ?
                new ObjectParameter("FECHA2", fECHA2) :
                new ObjectParameter("FECHA2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SELECT_FACTURAS_Result>("SP_SELECT_FACTURAS", fECHA1Parameter, fECHA2Parameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> SP_TOTAL_FACTURAS(string ctipdoc)
        {
            var ctipdocParameter = ctipdoc != null ?
                new ObjectParameter("ctipdoc", ctipdoc) :
                new ObjectParameter("ctipdoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("SP_TOTAL_FACTURAS", ctipdocParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> SP_TOTAL_FACTURAS_TODO(string ctipdoc)
        {
            var ctipdocParameter = ctipdoc != null ?
                new ObjectParameter("ctipdoc", ctipdoc) :
                new ObjectParameter("ctipdoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("SP_TOTAL_FACTURAS_TODO", ctipdocParameter);
        }
    
        public virtual ObjectResult<BUSQ_CLIDEP_Result> BUSQ_CLIDEP(string cODEMPRESA, string cODCLIENTE)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cODCLIENTEParameter = cODCLIENTE != null ?
                new ObjectParameter("CODCLIENTE", cODCLIENTE) :
                new ObjectParameter("CODCLIENTE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BUSQ_CLIDEP_Result>("BUSQ_CLIDEP", cODEMPRESAParameter, cODCLIENTEParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> BUSCA_FECHA(string cODEMPRESA, string pTOVTA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var pTOVTAParameter = pTOVTA != null ?
                new ObjectParameter("PTOVTA", pTOVTA) :
                new ObjectParameter("PTOVTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("BUSCA_FECHA", cODEMPRESAParameter, pTOVTAParameter);
        }
    
        public virtual ObjectResult<BUSCAPROVEEDOR_Result> BUSCAPROVEEDOR(string nROPEDIDO)
        {
            var nROPEDIDOParameter = nROPEDIDO != null ?
                new ObjectParameter("NROPEDIDO", nROPEDIDO) :
                new ObjectParameter("NROPEDIDO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BUSCAPROVEEDOR_Result>("BUSCAPROVEEDOR", nROPEDIDOParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> BUSCAR_CORREL_LINEA(string cODLINEA, string cODEMPRESA)
        {
            var cODLINEAParameter = cODLINEA != null ?
                new ObjectParameter("CODLINEA", cODLINEA) :
                new ObjectParameter("CODLINEA", typeof(string));
    
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("BUSCAR_CORREL_LINEA", cODLINEAParameter, cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> SP_VERIFICA_NROPTOVTA(string nROPTOVTA)
        {
            var nROPTOVTAParameter = nROPTOVTA != null ?
                new ObjectParameter("NROPTOVTA", nROPTOVTA) :
                new ObjectParameter("NROPTOVTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("SP_VERIFICA_NROPTOVTA", nROPTOVTAParameter);
        }
    
        public virtual ObjectResult<SP_REPORTE_PEDIDO_XVENDEDOR_Result> SP_REPORTE_PEDIDO_XVENDEDOR(string cORREL)
        {
            var cORRELParameter = cORREL != null ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REPORTE_PEDIDO_XVENDEDOR_Result>("SP_REPORTE_PEDIDO_XVENDEDOR", cORRELParameter);
        }
    
        public virtual int BORRAR_VENTA_X_COBRAR(string cORRNBR)
        {
            var cORRNBRParameter = cORRNBR != null ?
                new ObjectParameter("CORRNBR", cORRNBR) :
                new ObjectParameter("CORRNBR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BORRAR_VENTA_X_COBRAR", cORRNBRParameter);
        }
    
        public virtual int SP_PEDIDO_XVENDEDOR(string fECHAD, string fECHAH, string cORREL)
        {
            var fECHADParameter = fECHAD != null ?
                new ObjectParameter("FECHAD", fECHAD) :
                new ObjectParameter("FECHAD", typeof(string));
    
            var fECHAHParameter = fECHAH != null ?
                new ObjectParameter("FECHAH", fECHAH) :
                new ObjectParameter("FECHAH", typeof(string));
    
            var cORRELParameter = cORREL != null ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_PEDIDO_XVENDEDOR", fECHADParameter, fECHAHParameter, cORRELParameter);
        }
    
        public virtual int BORRA_TEMPORALES(string pTOVTA)
        {
            var pTOVTAParameter = pTOVTA != null ?
                new ObjectParameter("PTOVTA", pTOVTA) :
                new ObjectParameter("PTOVTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BORRA_TEMPORALES", pTOVTAParameter);
        }
    
        public virtual ObjectResult<NSP_SELECT_CORRELATIVOS_Result> NSP_SELECT_CORRELATIVOS(string pTOVTA, string cODEMPRESA)
        {
            var pTOVTAParameter = pTOVTA != null ?
                new ObjectParameter("PTOVTA", pTOVTA) :
                new ObjectParameter("PTOVTA", typeof(string));
    
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NSP_SELECT_CORRELATIVOS_Result>("NSP_SELECT_CORRELATIVOS", pTOVTAParameter, cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<SP_REPORTE_COBRANZA_Result> SP_REPORTE_COBRANZA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REPORTE_COBRANZA_Result>("SP_REPORTE_COBRANZA");
        }
    
        public virtual ObjectResult<Nsp_Sele_banco_Result> Nsp_Sele_banco(string codempresa)
        {
            var codempresaParameter = codempresa != null ?
                new ObjectParameter("codempresa", codempresa) :
                new ObjectParameter("codempresa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nsp_Sele_banco_Result>("Nsp_Sele_banco", codempresaParameter);
        }
    
        public virtual ObjectResult<NSP_AGRUP_FECHA_Result> NSP_AGRUP_FECHA(string cODEMPRESA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NSP_AGRUP_FECHA_Result>("NSP_AGRUP_FECHA", cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result> SP_RPT_VENTAS_DETALLE_POR_DOCU(string cODI)
        {
            var cODIParameter = cODI != null ?
                new ObjectParameter("CODI", cODI) :
                new ObjectParameter("CODI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result>("SP_RPT_VENTAS_DETALLE_POR_DOCU", cODIParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> SP_SELECT_COBRANZAXCLIENTE(string cODEMP, string cODCLIENTE)
        {
            var cODEMPParameter = cODEMP != null ?
                new ObjectParameter("CODEMP", cODEMP) :
                new ObjectParameter("CODEMP", typeof(string));
    
            var cODCLIENTEParameter = cODCLIENTE != null ?
                new ObjectParameter("CODCLIENTE", cODCLIENTE) :
                new ObjectParameter("CODCLIENTE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("SP_SELECT_COBRANZAXCLIENTE", cODEMPParameter, cODCLIENTEParameter);
        }
    
        public virtual ObjectResult<SP_LISTA_ARTICULO_FACT_Result> SP_LISTA_ARTICULO_FACT(string cODEMPRESA, string cDZONA, Nullable<int> tIPO)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cDZONAParameter = cDZONA != null ?
                new ObjectParameter("CDZONA", cDZONA) :
                new ObjectParameter("CDZONA", typeof(string));
    
            var tIPOParameter = tIPO.HasValue ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTA_ARTICULO_FACT_Result>("SP_LISTA_ARTICULO_FACT", cODEMPRESAParameter, cDZONAParameter, tIPOParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> SP_SUMPEDIDO(string cODCLIENTE)
        {
            var cODCLIENTEParameter = cODCLIENTE != null ?
                new ObjectParameter("CODCLIENTE", cODCLIENTE) :
                new ObjectParameter("CODCLIENTE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("SP_SUMPEDIDO", cODCLIENTEParameter);
        }
    
        public virtual ObjectResult<USP_CONFIGINV_Result> USP_CONFIGINV(string cODEMPRESA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONFIGINV_Result>("USP_CONFIGINV", cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<SP_EXTRAER_AÑO_MES_Result> SP_EXTRAER_AÑO_MES(string cODEMPRESA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EXTRAER_AÑO_MES_Result>("SP_EXTRAER_AÑO_MES", cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_BUSQUEDA_CLIENTE_VTA(string cODEMPRESA, string cODDEP, string vENTACAB)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cODDEPParameter = cODDEP != null ?
                new ObjectParameter("CODDEP", cODDEP) :
                new ObjectParameter("CODDEP", typeof(string));
    
            var vENTACABParameter = vENTACAB != null ?
                new ObjectParameter("VENTACAB", vENTACAB) :
                new ObjectParameter("VENTACAB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_BUSQUEDA_CLIENTE_VTA", cODEMPRESAParameter, cODDEPParameter, vENTACABParameter);
        }
    
        public virtual ObjectResult<string> VERIFICA_HISTORICOVENT(string cADVENT, string cODEMPRESA)
        {
            var cADVENTParameter = cADVENT != null ?
                new ObjectParameter("CADVENT", cADVENT) :
                new ObjectParameter("CADVENT", typeof(string));
    
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("VERIFICA_HISTORICOVENT", cADVENTParameter, cODEMPRESAParameter);
        }
    
        public virtual ObjectResult<string> SP_BUSQUEDA_CLIENTE_PEDIDO(string cODEMPRESA, string cODDEP)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cODDEPParameter = cODDEP != null ?
                new ObjectParameter("CODDEP", cODDEP) :
                new ObjectParameter("CODDEP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_BUSQUEDA_CLIENTE_PEDIDO", cODEMPRESAParameter, cODDEPParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_BUSQUEDA_CLIENTEDEP_VTA(string cODEMPRESA, string cODDEP, string vENTACAB)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cODDEPParameter = cODDEP != null ?
                new ObjectParameter("CODDEP", cODDEP) :
                new ObjectParameter("CODDEP", typeof(string));
    
            var vENTACABParameter = vENTACAB != null ?
                new ObjectParameter("VENTACAB", vENTACAB) :
                new ObjectParameter("VENTACAB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_BUSQUEDA_CLIENTEDEP_VTA", cODEMPRESAParameter, cODDEPParameter, vENTACABParameter);
        }
    
        public virtual ObjectResult<SP_RPT_CLIENTE_Result> SP_RPT_CLIENTE(string cODEMP)
        {
            var cODEMPParameter = cODEMP != null ?
                new ObjectParameter("CODEMP", cODEMP) :
                new ObjectParameter("CODEMP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_CLIENTE_Result>("SP_RPT_CLIENTE", cODEMPParameter);
        }
    
        public virtual ObjectResult<SP_REPORTE_CLIENTEDEP_PERCEP_Result> SP_REPORTE_CLIENTEDEP_PERCEP(string cODEMPRESA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REPORTE_CLIENTEDEP_PERCEP_Result>("SP_REPORTE_CLIENTEDEP_PERCEP", cODEMPRESAParameter);
        }
    
        public virtual int CUR_TMP_DATOSPROD_HISTO(string cODEMPRESA, string vENTADETHIST, Nullable<int> hISTO, Nullable<int> cORREL)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var vENTADETHISTParameter = vENTADETHIST != null ?
                new ObjectParameter("VENTADETHIST", vENTADETHIST) :
                new ObjectParameter("VENTADETHIST", typeof(string));
    
            var hISTOParameter = hISTO.HasValue ?
                new ObjectParameter("HISTO", hISTO) :
                new ObjectParameter("HISTO", typeof(int));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CUR_TMP_DATOSPROD_HISTO", cODEMPRESAParameter, vENTADETHISTParameter, hISTOParameter, cORRELParameter);
        }
    
        public virtual ObjectResult<NSP_RPT_EQUIPOVENTAS_Result> NSP_RPT_EQUIPOVENTAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NSP_RPT_EQUIPOVENTAS_Result>("NSP_RPT_EQUIPOVENTAS");
        }
    
        public virtual ObjectResult<NSP_RPT_DESCEXT_Result> NSP_RPT_DESCEXT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NSP_RPT_DESCEXT_Result>("NSP_RPT_DESCEXT");
        }
    
        public virtual int DEL_SEGUROS(string cODSEG)
        {
            var cODSEGParameter = cODSEG != null ?
                new ObjectParameter("CODSEG", cODSEG) :
                new ObjectParameter("CODSEG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEL_SEGUROS", cODSEGParameter);
        }
    
        public virtual ObjectResult<ZSP_RPT_DESCEXT_Result> ZSP_RPT_DESCEXT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ZSP_RPT_DESCEXT_Result>("ZSP_RPT_DESCEXT");
        }
    
        public virtual int SP_DEL_TMP_DOC_ANULADOS(Nullable<int> cORREL)
        {
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DEL_TMP_DOC_ANULADOS", cORRELParameter);
        }
    
        public virtual int SP_DEL_TMP_DATOSPROD(Nullable<int> cORREL)
        {
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DEL_TMP_DATOSPROD", cORRELParameter);
        }
    
        public virtual int SP_DEL_TMP_ARTIDEV(Nullable<int> cORREL)
        {
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DEL_TMP_ARTIDEV", cORRELParameter);
        }
    
        public virtual int SP_INS_TMP_DOC_ANULADOS(string cODEMPRESA, Nullable<System.DateTime> fECHAD, Nullable<System.DateTime> fECHAH, string vENTADETHIST, Nullable<int> hISTO, Nullable<int> cORREL)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var fECHADParameter = fECHAD.HasValue ?
                new ObjectParameter("FECHAD", fECHAD) :
                new ObjectParameter("FECHAD", typeof(System.DateTime));
    
            var fECHAHParameter = fECHAH.HasValue ?
                new ObjectParameter("FECHAH", fECHAH) :
                new ObjectParameter("FECHAH", typeof(System.DateTime));
    
            var vENTADETHISTParameter = vENTADETHIST != null ?
                new ObjectParameter("VENTADETHIST", vENTADETHIST) :
                new ObjectParameter("VENTADETHIST", typeof(string));
    
            var hISTOParameter = hISTO.HasValue ?
                new ObjectParameter("HISTO", hISTO) :
                new ObjectParameter("HISTO", typeof(int));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_TMP_DOC_ANULADOS", cODEMPRESAParameter, fECHADParameter, fECHAHParameter, vENTADETHISTParameter, hISTOParameter, cORRELParameter);
        }
    
        public virtual int CUR_TMP_ARTIDEV_HISTO(string cODEMPRESA, string vENTADETHIST, Nullable<int> cORREL)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var vENTADETHISTParameter = vENTADETHIST != null ?
                new ObjectParameter("VENTADETHIST", vENTADETHIST) :
                new ObjectParameter("VENTADETHIST", typeof(string));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CUR_TMP_ARTIDEV_HISTO", cODEMPRESAParameter, vENTADETHISTParameter, cORRELParameter);
        }
    
        public virtual int CUR_TMP_ARTIDEV_HISTO2(string cODEMPRESA, Nullable<int> cORREL)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CUR_TMP_ARTIDEV_HISTO2", cODEMPRESAParameter, cORRELParameter);
        }
    
        public virtual int CUR_TMP_ARTIDEV_HISTO3(string cODEMPRESA, Nullable<int> cORREL)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CUR_TMP_ARTIDEV_HISTO3", cODEMPRESAParameter, cORRELParameter);
        }
    
        public virtual int SP_DELETE_TMP_RPT_REPOR_SUNA(string cORREL)
        {
            var cORRELParameter = cORREL != null ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_TMP_RPT_REPOR_SUNA", cORRELParameter);
        }
    
        public virtual int SP_RPT_VTA_SUNA_ANUL(string cODEMP, Nullable<System.DateTime> fECHAD, Nullable<System.DateTime> fECHAH, string cODDOCUM, Nullable<int> cORREL, string vENTCAB, string vENTDET)
        {
            var cODEMPParameter = cODEMP != null ?
                new ObjectParameter("CODEMP", cODEMP) :
                new ObjectParameter("CODEMP", typeof(string));
    
            var fECHADParameter = fECHAD.HasValue ?
                new ObjectParameter("FECHAD", fECHAD) :
                new ObjectParameter("FECHAD", typeof(System.DateTime));
    
            var fECHAHParameter = fECHAH.HasValue ?
                new ObjectParameter("FECHAH", fECHAH) :
                new ObjectParameter("FECHAH", typeof(System.DateTime));
    
            var cODDOCUMParameter = cODDOCUM != null ?
                new ObjectParameter("CODDOCUM", cODDOCUM) :
                new ObjectParameter("CODDOCUM", typeof(string));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            var vENTCABParameter = vENTCAB != null ?
                new ObjectParameter("VENTCAB", vENTCAB) :
                new ObjectParameter("VENTCAB", typeof(string));
    
            var vENTDETParameter = vENTDET != null ?
                new ObjectParameter("VENTDET", vENTDET) :
                new ObjectParameter("VENTDET", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_RPT_VTA_SUNA_ANUL", cODEMPParameter, fECHADParameter, fECHAHParameter, cODDOCUMParameter, cORRELParameter, vENTCABParameter, vENTDETParameter);
        }
    
        public virtual ObjectResult<SP_LISTA_ARTICULO_FACT_FILTRO_Result> SP_LISTA_ARTICULO_FACT_FILTRO(string cODEMPRESA, string cDZONA, Nullable<int> tIPO, string tEXTO)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cDZONAParameter = cDZONA != null ?
                new ObjectParameter("CDZONA", cDZONA) :
                new ObjectParameter("CDZONA", typeof(string));
    
            var tIPOParameter = tIPO.HasValue ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(int));
    
            var tEXTOParameter = tEXTO != null ?
                new ObjectParameter("TEXTO", tEXTO) :
                new ObjectParameter("TEXTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTA_ARTICULO_FACT_FILTRO_Result>("SP_LISTA_ARTICULO_FACT_FILTRO", cODEMPRESAParameter, cDZONAParameter, tIPOParameter, tEXTOParameter);
        }
    
        public virtual ObjectResult<SelectPRECIART_Presentxproc2_Result> SelectPRECIART_Presentxproc2(string cODEMPRESA, string cDARTI)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cDARTIParameter = cDARTI != null ?
                new ObjectParameter("CDARTI", cDARTI) :
                new ObjectParameter("CDARTI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPRECIART_Presentxproc2_Result>("SelectPRECIART_Presentxproc2", cODEMPRESAParameter, cDARTIParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> NSP_UPDATE_TMP_STOCKPEDIDO(string cODEMPRESA, Nullable<int> cORREL, string cODARTI, Nullable<decimal> sTOCK_ACT_UND)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            var cODARTIParameter = cODARTI != null ?
                new ObjectParameter("CODARTI", cODARTI) :
                new ObjectParameter("CODARTI", typeof(string));
    
            var sTOCK_ACT_UNDParameter = sTOCK_ACT_UND.HasValue ?
                new ObjectParameter("STOCK_ACT_UND", sTOCK_ACT_UND) :
                new ObjectParameter("STOCK_ACT_UND", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("NSP_UPDATE_TMP_STOCKPEDIDO", cODEMPRESAParameter, cORRELParameter, cODARTIParameter, sTOCK_ACT_UNDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_EXTAER_STOCK(string cdarti, string cDALMA, string cORREL)
        {
            var cdartiParameter = cdarti != null ?
                new ObjectParameter("cdarti", cdarti) :
                new ObjectParameter("cdarti", typeof(string));
    
            var cDALMAParameter = cDALMA != null ?
                new ObjectParameter("CDALMA", cDALMA) :
                new ObjectParameter("CDALMA", typeof(string));
    
            var cORRELParameter = cORREL != null ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_EXTAER_STOCK", cdartiParameter, cDALMAParameter, cORRELParameter);
        }
    
        public virtual ObjectResult<SelectPRECIART_PresentxprocSUBCAT_Result> SelectPRECIART_PresentxprocSUBCAT(string cODEMPRESA, string cODLINEA, string sUBCODLINEA)
        {
            var cODEMPRESAParameter = cODEMPRESA != null ?
                new ObjectParameter("CODEMPRESA", cODEMPRESA) :
                new ObjectParameter("CODEMPRESA", typeof(string));
    
            var cODLINEAParameter = cODLINEA != null ?
                new ObjectParameter("CODLINEA", cODLINEA) :
                new ObjectParameter("CODLINEA", typeof(string));
    
            var sUBCODLINEAParameter = sUBCODLINEA != null ?
                new ObjectParameter("SUBCODLINEA", sUBCODLINEA) :
                new ObjectParameter("SUBCODLINEA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPRECIART_PresentxprocSUBCAT_Result>("SelectPRECIART_PresentxprocSUBCAT", cODEMPRESAParameter, cODLINEAParameter, sUBCODLINEAParameter);
        }
    
        public virtual ObjectResult<SP_RPT_VTA_ANUL_Result> SP_RPT_VTA_ANUL(Nullable<int> cORREL)
        {
            var cORRELParameter = cORREL.HasValue ?
                new ObjectParameter("CORREL", cORREL) :
                new ObjectParameter("CORREL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RPT_VTA_ANUL_Result>("SP_RPT_VTA_ANUL", cORRELParameter);
        }
    }
}
