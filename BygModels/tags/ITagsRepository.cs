using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.tags
{
    public interface ITagsRepository
    {
        /// <summary>
        /// verifica si una tag ya existe por su nombre
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public Task<int> IsExistsAsync(string detail);

        /// <summary>
        /// va a insertar una nueva tag
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="icon"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public Task<int> InsertTagsAsync(string detail, string icon, string color);
    }
}
