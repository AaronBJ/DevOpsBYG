
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import { createPinia } from 'pinia'
import { useTagsStore } from '@/setup/tagsService'

const app = createApp(App)
app.use(createPinia())

const tagsStore = useTagsStore()
tagsStore.fetchTags()

app.use(router)
app.mount('#app')        
