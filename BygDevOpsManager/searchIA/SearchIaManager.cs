using BygModels.enums;
using BygModels.searchIa;
using BygModels.searchIa.model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BygDevOpsManager.searchIA
{
    public class SearchIaManager : ISearchIaManager
    {
        public Task<IEnumerable<SearchIaBaseModel>> GetSearchAsync()
        {
            var result = new List<SearchIaBaseModel>
            {
                new SearchIaBaseModel
                {
                    Image = "/images/inventario.png",
                    Title = "Inventario General",
                    Link = "/inventario",
                    CategoryColor = "#2F5FA8",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/ventas.png",
                    Title = "Panel de Ventas",
                    Link = "/ventas",
                    CategoryColor = "#4CAF9A",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/clientes.png",
                    Title = "Gestión de Clientes",
                    Link = "/clientes",
                    CategoryColor = "#8B7CF6",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/compras.png",
                    Title = "Órdenes de Compra",
                    Link = "/compras",
                    CategoryColor = "#F59E0B",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/proveedores.png",
                    Title = "Proveedores",
                    Link = "/proveedores",
                    CategoryColor = "#F97316",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/reportes.png",
                    Title = "Reportes Financieros",
                    Link = "/reportes",
                    CategoryColor = "#10B981",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/dashboard.png",
                    Title = "Dashboard Ejecutivo",
                    Link = "/dashboard",
                    CategoryColor = "#0EA5E9",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/usuarios.png",
                    Title = "Usuarios del Sistema",
                    Link = "/usuarios",
                    CategoryColor = "#6366F1",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/configuracion.png",
                    Title = "Configuración",
                    Link = "/configuracion",
                    CategoryColor = "#64748B",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/notificaciones.png",
                    Title = "Centro de Notificaciones",
                    Link = "/notificaciones",
                    CategoryColor = "#EC4899",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/calendario.png",
                    Title = "Calendario de Eventos",
                    Link = "/calendario",
                    CategoryColor = "#14B8A6",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/facturas.png",
                    Title = "Facturación Electrónica",
                    Link = "/facturas",
                    CategoryColor = "#22C55E",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/empleados.png",
                    Title = "Recursos Humanos",
                    Link = "/empleados",
                    CategoryColor = "#A855F7",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/seguridad.png",
                    Title = "Seguridad del Sistema",
                    Link = "/seguridad",
                    CategoryColor = "#EF4444",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/marketing.png",
                    Title = "Campañas de Marketing",
                    Link = "/marketing",
                    CategoryColor = "#F43F5E",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/estadisticas.png",
                    Title = "Estadísticas Avanzadas",
                    Link = "/estadisticas",
                    CategoryColor = "#06B6D4",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/envios.png",
                    Title = "Seguimiento de Envíos",
                    Link = "/envios",
                    CategoryColor = "#0F766E",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/soporte.png",
                    Title = "Mesa de Soporte",
                    Link = "/soporte",
                    CategoryColor = "#2563EB",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/documentos.png",
                    Title = "Documentación",
                    Link = "/documentos",
                    CategoryColor = "#7C3AED",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/tareas.png",
                    Title = "Gestión de Tareas",
                    Link = "/tareas",
                    CategoryColor = "#84CC16",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/chat.png",
                    Title = "Chat Corporativo",
                    Link = "/chat",
                    CategoryColor = "#3B82F6",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/pagos.png",
                    Title = "Control de Pagos",
                    Link = "/pagos",
                    CategoryColor = "#16A34A",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/analitica.png",
                    Title = "Analítica Web",
                    Link = "/analitica",
                    CategoryColor = "#0891B2",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/agenda.png",
                    Title = "Agenda Empresarial",
                    Link = "/agenda",
                    CategoryColor = "#9333EA",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/contratos.png",
                    Title = "Contratos Digitales",
                    Link = "/contratos",
                    CategoryColor = "#475569",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/productos.png",
                    Title = "Catálogo de Productos",
                    Link = "/productos",
                    CategoryColor = "#EA580C",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/sucursales.png",
                    Title = "Sucursales",
                    Link = "/sucursales",
                    CategoryColor = "#0284C7",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/ia.png",
                    Title = "Asistente IA",
                    Link = "/ia",
                    CategoryColor = "#7C3AED",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/auditoria.png",
                    Title = "Auditoría Interna",
                    Link = "/auditoria",
                    CategoryColor = "#DC2626",
                    Category = CategoryAreasEnum.Inventory
                },

                new SearchIaBaseModel
                {
                    Image = "/images/backup.png",
                    Title = "Respaldo y Recuperación",
                    Link = "/backup",
                    CategoryColor = "#334155",
                    Category = CategoryAreasEnum.Inventory
                }
            };

            return Task.FromResult<IEnumerable<SearchIaBaseModel>>(result);
        }
    }
}