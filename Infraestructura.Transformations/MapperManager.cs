using AutoMapper;
using CapaDatafirst;
using Dominio.Entidades.Distribucion;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Departamento.Peticiones;
using Servicios.Interfaces.Departamento.Respuestas;
using Servicios.Interfaces.Facturacion.VentaCab.Peticiones;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using Servicios.Interfaces.FacturaElectronica.Peticiones;
using Servicios.Interfaces.FacturaElectronica.Respuestas;
using Servicios.Interfaces.Linea.Peticiones;
using Servicios.Interfaces.Linea.Respuestas;
using Servicios.Interfaces.Movimiento.Cabecera.Peticiones;
using Servicios.Interfaces.Movimiento.Cabecera.Respuestas;

using Servicios.Interfaces.TipoDoc.Peticiones;
using Servicios.Interfaces.TipoDoc.Respuestas;
using Servicios.Interfaces.Vendedor.Peticiones;
using Servicios.Interfaces.Vendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Distrito.Peticiones;
using Servicios.Interfaces.Distrito.Respuestas;
using Servicios.Interfaces.TipoPrecio.Peticiones;
using Servicios.Interfaces.TipoPrecio.Respuestas;
using Servicios.Interfaces.Pais.Peticiones;
using Servicios.Interfaces.Pais.Respuestas;
using Servicios.Interfaces.TipoNegocio.Peticiones;
using Servicios.Interfaces.TipoNegocio.Respuestas;
using Servicios.Interfaces.Ruta.Peticiones;
using Servicios.Interfaces.Ruta.Respuestas;
using Servicios.Interfaces.Ciudad.Peticiones;
using Servicios.Interfaces.Ciudad.Respuesta;
using Servicios.Interfaces.Cliente.Peticiones;
using Servicios.Interfaces.Cliente.Respuestas;
using Servicios.Interfaces.CliDep.Peticiones;
using Servicios.Interfaces.CliDep.Respuestas;
using Servicios.Interfaces.Cierre_Inv_Gloria.Peticiones;
using Servicios.Interfaces.Cierre_Inv_Gloria.Respuestas;
using Servicios.Interfaces.ClieFuerza.Peticiones;
using Servicios.Interfaces.ClieFuerza.Respuestas;
using Servicios.Interfaces.Facturacion.VentaDet.Peticiones;
using Servicios.Interfaces.Facturacion.VentaDet.Respuestas;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using Servicios.Interfaces.Jefe_Equipo.Peticiones;
using Servicios.Interfaces.Jefe_Equipo.Respuestas;
using Servicios.Interfaces.EquipoVendedor.Peticiones;
using Servicios.Interfaces.EquipoVendedor.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromocion.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using Servicios.Interfaces.ClienteXPromo.Peticiones;
using Servicios.Interfaces.ClienteXPromo.Respuestas;
using Servicios.Interfaces.Artidat.Peticiones;
using Servicios.Interfaces.Artidat.Respuestas;
using Servicios.Interfaces.TmpStockPedido.Peticiones;
using Servicios.Interfaces.TmpStockPedido.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Respuestas;
using Servicios.Interfaces.EntregaMercas.Peticiones;
using Servicios.Interfaces.EntregaMercas.Respuestas;
using Servicios.Interfaces.Supervisor.Peticiones;
using Servicios.Interfaces.Supervisor.Respuestas;
using Dominio.Contextos.Models;
using Servicios.Interfaces.SupervisorVendedor.Peticiones;
using Servicios.Interfaces.SupervisorVendedor.Respuestas;

namespace Infraestructura.Transformations
{
   public class MapperManager
    {
        public static void Initialize()
        {
            Mapper.Initialize(configuration => {

                configuration.CreateMap<HDocumento, HDocumentoRegistrado>();
                configuration.CreateMap<HDocumentoRegistrado, HDocumento>();
                configuration.CreateMap<NuevaHdocumento, HDocumento>();

                configuration.CreateMap<DDocumento, DDocumentoRegistrado>();
                configuration.CreateMap<DDocumentoRegistrado, DDocumento>();
                configuration.CreateMap<NuevaDDocumento, DDocumento>();

                configuration.CreateMap<CDocumento, CDocumentoRegistrado>();
                configuration.CreateMap<CDocumentoRegistrado, CDocumento>();
                configuration.CreateMap<NuevaCDocumento, CDocumento>();


                configuration.CreateMap<VendedorNuevo, VENDEDOR>();
                configuration.CreateMap<VENDEDOR, VendedorRegistrado>();
                configuration.CreateMap<VendedorActualizar, VENDEDOR>();

                configuration.CreateMap<NuevaVentacab, VentaAnulados>();
                configuration.CreateMap<VentaAnulados, VentaCabRegistrado>();
                configuration.CreateMap<VentacabActualizar, VentaAnulados>();


                configuration.CreateMap<NuevaVentacab, VentaCabFE>();
                configuration.CreateMap<VentaCabFE, VentaCabRegistrado>();
                configuration.CreateMap<VentacabActualizar, VentaCabFE>();



                configuration.CreateMap<NuevaVentaDet, VentaDetFE>();
                configuration.CreateMap<VentaDetFE, VentaDetRegistrado>();
        



                configuration.CreateMap<LineaNuevo, LINEA>();
                configuration.CreateMap<LINEA, LineaRegistrado>();
                configuration.CreateMap<LineaActualizar, LINEA>();


                configuration.CreateMap<TipoDocNuevo, TIPODOC>();
                configuration.CreateMap<TIPODOC, TipoDocRegistrado>();
                configuration.CreateMap<TipoDocActualizar, TIPODOC>();


                configuration.CreateMap<PaisNuevo, PAIS>();
                configuration.CreateMap<PAIS, PaisRegistrado>();
                configuration.CreateMap<PaisActualizar, PAIS>();

                configuration.CreateMap<DepartamentoNuevo, paisdepa>();
                configuration.CreateMap<paisdepa, DepartamentoRegistrado>();
                configuration.CreateMap<DepartamentoActualizar, paisdepa>();

                configuration.CreateMap<CiudadNuevo, CIUDAD>();
                configuration.CreateMap<CIUDAD, CiudadRegistrado>();
                configuration.CreateMap<CiudadActualizar, CIUDAD>();

                configuration.CreateMap<DistritoNuevo, Distrito>();
                configuration.CreateMap<Distrito, DistritoRegistrado>();
                configuration.CreateMap<DistritoActualizar, Distrito>();

                configuration.CreateMap<TipoPrecioNuevo, TIPOPRE>();
                configuration.CreateMap<TIPOPRE, TipoPrecioRegistrado>();
                configuration.CreateMap<TipoPrecioActualizar, TIPOPRE>();

                configuration.CreateMap<TipoNegocioNuevo, TIPONEGOCIO>();
                configuration.CreateMap<TIPONEGOCIO, TipoNegocioRegistrado>();
                configuration.CreateMap<TipoNegocioActualizar, TIPONEGOCIO>();

                configuration.CreateMap<RutaNuevo, RUTA>();
                configuration.CreateMap<RUTA, RutaRegistrado>();
                configuration.CreateMap<RutaActualizar, RUTA>();

                configuration.CreateMap<ClienteNuevo, CLIENTE>();
                configuration.CreateMap<CLIENTE, ClienteRegistrado>();
                configuration.CreateMap<CLIENTE, CIienteSelecionado1>();
                configuration.CreateMap<ClienteActualizar, CLIENTE>();


                configuration.CreateMap<CliDepNuevo, CLIDEP>();
                configuration.CreateMap<CLIDEP, CliDepRegistrado>();
                configuration.CreateMap<CLIDEP, CliDepRegistradoMas>();
                configuration.CreateMap<CliDepActualizar, CLIDEP>();

                configuration.CreateMap<Cierre_Inv_GloriaNuevo, Cierre_Inv_Gloria>();
                configuration.CreateMap<Cierre_Inv_Gloria, Cierre_Inv_GloriaRegistrado>();
                configuration.CreateMap<Cierre_Inv_GloriaActualizar, Cierre_Inv_Gloria>();

                configuration.CreateMap<Cierre_Inv_GloriaNuevo, Cierre_Inv_Gloria>();
                configuration.CreateMap<Cierre_Inv_Gloria, Cierre_Inv_GloriaRegistrado>();
                configuration.CreateMap<Cierre_Inv_GloriaActualizar, Cierre_Inv_Gloria>();

                configuration.CreateMap<Cierre_Inv_GloriaNuevo, Cierre_Inv_Protisa>();
                configuration.CreateMap<Cierre_Inv_Protisa, Cierre_Inv_GloriaRegistrado>();
                configuration.CreateMap<Cierre_Inv_GloriaActualizar, Cierre_Inv_Protisa>();

                configuration.CreateMap<ClieFuerzaNuevo, CLIE_FUERZA>();
                configuration.CreateMap<CLIE_FUERZA, ClieFuerzaRegistrado>();
                configuration.CreateMap<CLIE_FUERZA, ClieFuerzaListar>();
                configuration.CreateMap<ClieFuerzaActualizar, CLIE_FUERZA>();

                configuration.CreateMap<EquipoNuevo, Equipo>();
                configuration.CreateMap<Equipo, EquipoRegistrado>();
                configuration.CreateMap<EquipoActualizar, Equipo>();

                configuration.CreateMap<Jefe_EquipoNuevo, Jefe_Equipo>();
                configuration.CreateMap<Jefe_Equipo, Jefe_EquipoRegistro>();
                configuration.CreateMap<Jefe_EquipoActualizar, Jefe_Equipo>();

                configuration.CreateMap<Equipo_VendedorNuevo, Equipo_Vendedor>();
                configuration.CreateMap<Equipo_Vendedor, Equipo_VendedorRegistrado>();
                configuration.CreateMap<Equipo_VendedorActualizar, Equipo_Vendedor>();


                configuration.CreateMap<TipoPrecioXPromNuevo, TipoPrecioXPromocion>();
                configuration.CreateMap<TipoPrecioXPromocion, TipoPrecioXPromRegistrado>();
                configuration.CreateMap<TipoPrecioXPromActualizar, TipoPrecioXPromocion>();


                configuration.CreateMap<ClienteXPromoNuevo, ClienteXPromo>();
                configuration.CreateMap<ClienteXPromo, ClienteXPromoRegistrado>();
                configuration.CreateMap<ClienteXPromoAct, ClienteXPromo>();

                configuration.CreateMap<ArtidatNuevo, ARTIDAT>();
                configuration.CreateMap<ARTIDAT, ArtidatRegistrado>();
                configuration.CreateMap<ArtidatActualizar, ARTIDAT>();


                configuration.CreateMap<TmpStockPedidoNuevo, TMP_STOCKPEDIDO>();
                configuration.CreateMap<TMP_STOCKPEDIDO, TmpStockPedidoRegistrado>();
                configuration.CreateMap<TmpStockPedidoActualizar, TMP_STOCKPEDIDO>();

                configuration.CreateMap<ArtidatNuevo, ARTIDAT>();
                configuration.CreateMap<ARTIDAT, ArtidatRegistrado>();
                configuration.CreateMap<ArtidatActualizar, ARTIDAT>();


                configuration.CreateMap<TipoPrecioXPromSubCatSolNuevo, TipoPrecioXPromoSubCatSoles>();
                configuration.CreateMap<TipoPrecioXPromoSubCatSoles, TipoPrecioXPromSubCatSolReg>();
                configuration.CreateMap<TipoPrecioXPromSubCatSolAct, TipoPrecioXPromoSubCatSoles>();

                configuration.CreateMap<TipoPrecioXPromoSolesNuevo, TipoPrecioXPromoSoles>();
                configuration.CreateMap<TipoPrecioXPromoSoles, TipoPrecioXPromoSolesReg>();
                configuration.CreateMap<TipoPrecioXPromoSolesAct, TipoPrecioXPromoSoles>();

                configuration.CreateMap<EntregaMercaNuevo, EntregaMerca>();
                configuration.CreateMap<EntregaMerca, EntregaMercaRegistrado>();

                configuration.CreateMap<SupervisorNuevo, Supervisor>();
                configuration.CreateMap<Supervisor, SupervisorRegistrado>();
                configuration.CreateMap<SupervisorActualizar, Supervisor>();


                configuration.CreateMap<SupervisorVendedorNuevo, SupervisorVendedor>();
                configuration.CreateMap<SupervisorVendedor, SupervisorVendedorRegistrado>();
                configuration.CreateMap<SupervisorVendedorActualizar, SupervisorVendedor>();



            });
        }
    }
}
