import { defineStore } from 'pinia'
import axios from 'axios'
import type { TagModel } from '@/interFaces/tagsModel'


export const useTagsStore = defineStore('tags', {
  state: () => ({
    tags: [] as TagModel[]
  }),
  actions: {
    async fetchTags() {
      const { data } = await axios.get('https://localhost:44329/Tags')
      
      this.tags = data
      
    }
  }
})
