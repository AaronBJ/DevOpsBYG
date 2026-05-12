using BygModels.searchIa.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.searchIa
{
    public interface ISearchIaManager
    {
        public Task<IEnumerable<SearchIaBaseModel>> GetSearchAsync();
    }
}
