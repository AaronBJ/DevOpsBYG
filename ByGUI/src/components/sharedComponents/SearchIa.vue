<template>
  <transition name="overlay-fade">
    <div v-if="visible"
         class="overlay"
         @click.self="close">
      <div class="search-panel">

        <!-- Input -->
        <input v-model="query"
               type="text"
               placeholder="Buscar módulos..."
               class="search-input" />

        <!-- Resultados -->
        <div class="results">

          <div v-for="item in filteredData"
               :key="item['texto-title']"
               class="result-item"
               @click="goTo(item['url-link'])">
            <img :src="item.imagen"
                 class="result-img" />

            <div class="result-info">

              <span class="title">
                {{ item["texto-title"] }}
              </span>

              <span class="category"
                    :style="{ backgroundColor: item['category-color'] }">
                {{ item["category-title"] }}
              </span>

            </div>

          </div>

        </div>

      </div>
    </div>
  </transition>
</template>

<script setup lang="ts">
  import { ref, computed } from 'vue'

  const props = defineProps<{
    visible: boolean
  }>()

  const emit = defineEmits(['close'])

  const query = ref('')

  const data = ref([
    {
      "imagen": "/images/inventario.png",
      "texto-title": "Inventario General",
      "url-link": "/inventario",
      "category-title": "Almacén",
      "category-color": "#2F5FA8"
    },
    {
      "imagen": "/images/ventas.png",
      "texto-title": "Panel de Ventas",
      "url-link": "/ventas",
      "category-title": "Comercial",
      "category-color": "#4CAF9A"
    },
    {
      "imagen": "/images/clientes.png",
      "texto-title": "Gestión de Clientes",
      "url-link": "/clientes",
      "category-title": "CRM",
      "category-color": "#8B7CF6"
    },
    {
      "imagen": "/images/compras.png",
      "texto-title": "Órdenes de Compra",
      "url-link": "/compras",
      "category-title": "Compras",
      "category-color": "#F59E0B"
    },
    {
      "imagen": "/images/proveedores.png",
      "texto-title": "Proveedores",
      "url-link": "/proveedores",
      "category-title": "Compras",
      "category-color": "#F97316"
    },
    {
      "imagen": "/images/reportes.png",
      "texto-title": "Reportes Financieros",
      "url-link": "/reportes",
      "category-title": "Finanzas",
      "category-color": "#10B981"
    },
    {
      "imagen": "/images/dashboard.png",
      "texto-title": "Dashboard Ejecutivo",
      "url-link": "/dashboard",
      "category-title": "Analytics",
      "category-color": "#0EA5E9"
    },
    {
      "imagen": "/images/usuarios.png",
      "texto-title": "Usuarios del Sistema",
      "url-link": "/usuarios",
      "category-title": "Administración",
      "category-color": "#6366F1"
    },
    {
      "imagen": "/images/configuracion.png",
      "texto-title": "Configuración",
      "url-link": "/configuracion",
      "category-title": "Sistema",
      "category-color": "#64748B"
    },
    {
      "imagen": "/images/notificaciones.png",
      "texto-title": "Centro de Notificaciones",
      "url-link": "/notificaciones",
      "category-title": "Comunicación",
      "category-color": "#EC4899"
    },
    {
      "imagen": "/images/calendario.png",
      "texto-title": "Calendario de Eventos",
      "url-link": "/calendario",
      "category-title": "Organización",
      "category-color": "#14B8A6"
    },
    {
      "imagen": "/images/facturas.png",
      "texto-title": "Facturación Electrónica",
      "url-link": "/facturas",
      "category-title": "Finanzas",
      "category-color": "#22C55E"
    },
    {
      "imagen": "/images/empleados.png",
      "texto-title": "Recursos Humanos",
      "url-link": "/empleados",
      "category-title": "RH",
      "category-color": "#A855F7"
    },
    {
      "imagen": "/images/seguridad.png",
      "texto-title": "Seguridad del Sistema",
      "url-link": "/seguridad",
      "category-title": "Seguridad",
      "category-color": "#EF4444"
    },
    {
      "imagen": "/images/marketing.png",
      "texto-title": "Campañas de Marketing",
      "url-link": "/marketing",
      "category-title": "Marketing",
      "category-color": "#F43F5E"
    },
    {
      "imagen": "/images/estadisticas.png",
      "texto-title": "Estadísticas Avanzadas",
      "url-link": "/estadisticas",
      "category-title": "Analytics",
      "category-color": "#06B6D4"
    },
    {
      "imagen": "/images/envios.png",
      "texto-title": "Seguimiento de Envíos",
      "url-link": "/envios",
      "category-title": "Logística",
      "category-color": "#0F766E"
    },
    {
      "imagen": "/images/soporte.png",
      "texto-title": "Mesa de Soporte",
      "url-link": "/soporte",
      "category-title": "Atención",
      "category-color": "#2563EB"
    },
    {
      "imagen": "/images/documentos.png",
      "texto-title": "Documentación",
      "url-link": "/documentos",
      "category-title": "Archivos",
      "category-color": "#7C3AED"
    },
    {
      "imagen": "/images/tareas.png",
      "texto-title": "Gestión de Tareas",
      "url-link": "/tareas",
      "category-title": "Productividad",
      "category-color": "#84CC16"
    },
    {
      "imagen": "/images/chat.png",
      "texto-title": "Chat Corporativo",
      "url-link": "/chat",
      "category-title": "Comunicación",
      "category-color": "#3B82F6"
    },
    {
      "imagen": "/images/pagos.png",
      "texto-title": "Control de Pagos",
      "url-link": "/pagos",
      "category-title": "Finanzas",
      "category-color": "#16A34A"
    },
    {
      "imagen": "/images/analitica.png",
      "texto-title": "Analítica Web",
      "url-link": "/analitica",
      "category-title": "Marketing",
      "category-color": "#0891B2"
    },
    {
      "imagen": "/images/agenda.png",
      "texto-title": "Agenda Empresarial",
      "url-link": "/agenda",
      "category-title": "Organización",
      "category-color": "#9333EA"
    },
    {
      "imagen": "/images/contratos.png",
      "texto-title": "Contratos Digitales",
      "url-link": "/contratos",
      "category-title": "Legal",
      "category-color": "#475569"
    },
    {
      "imagen": "/images/productos.png",
      "texto-title": "Catálogo de Productos",
      "url-link": "/productos",
      "category-title": "Comercial",
      "category-color": "#EA580C"
    },
    {
      "imagen": "/images/sucursales.png",
      "texto-title": "Sucursales",
      "url-link": "/sucursales",
      "category-title": "Operaciones",
      "category-color": "#0284C7"
    },
    {
      "imagen": "/images/ia.png",
      "texto-title": "Asistente IA",
      "url-link": "/ia",
      "category-title": "Innovación",
      "category-color": "#7C3AED"
    },
    {
      "imagen": "/images/auditoria.png",
      "texto-title": "Auditoría Interna",
      "url-link": "/auditoria",
      "category-title": "Control",
      "category-color": "#DC2626"
    },
    {
      "imagen": "/images/backup.png",
      "texto-title": "Respaldo y Recuperación",
      "url-link": "/backup",
      "category-title": "Sistema",
      "category-color": "#334155"
    }
  ])

  const filteredData = computed(() => {
    return data.value.filter(item =>
      item["texto-title"]
        .toLowerCase()
        .includes(query.value.toLowerCase())
    )
  })

  const close = () => {
    emit('close')
  }

  const goTo = (url: string) => {
    window.location.href = url
  }
</script>

<style scoped>
  .overlay {
    position: fixed;
    inset: 0;
    background: rgba(0,0,0,0.65);
    backdrop-filter: blur(8px);
    display: flex;
    justify-content: center;
    align-items: flex-start;
    padding-top: 100px;
    z-index: 9999;
  }

  .search-panel {
    width: 90%;
    max-width: 650px;
    background: white;
    border-radius: 22px;
    padding: 20px;
    box-shadow: 0 20px 50px rgba(0,0,0,0.25);
  }

  .search-input {
    width: 100%;
    padding: 14px 18px;
    border: none;
    outline: none;
    border-radius: 14px;
    background: #F1F5F9;
    font-size: 16px;
    margin-bottom: 20px;
  }

  .results {
    display: flex;
    flex-direction: column;
    gap: 10px;
    max-height: 400px;
    overflow-y: auto;
  }

  .result-item {
    display: flex;
    align-items: center;
    gap: 14px;
    padding: 12px;
    border-radius: 14px;
    cursor: pointer;
    transition: background 0.2s ease, transform 0.2s ease;
  }

    .result-item:hover {
      background: #F8FAFC;
      transform: scale(1.01);
    }

  .result-img {
    width: 45px;
    height: 45px;
    border-radius: 10px;
  }

  .result-info {
    display: flex;
    flex-direction: column;
    gap: 5px;
  }

  .title {
    font-weight: 600;
  }

  .category {
    width: fit-content;
    color: white;
    font-size: 12px;
    padding: 4px 8px;
    border-radius: 999px;
  }

  .overlay-fade-enter-active,
  .overlay-fade-leave-active {
    transition: opacity 0.25s ease;
  }

  .overlay-fade-enter-from,
  .overlay-fade-leave-to {
    opacity: 0;
  }
</style>
