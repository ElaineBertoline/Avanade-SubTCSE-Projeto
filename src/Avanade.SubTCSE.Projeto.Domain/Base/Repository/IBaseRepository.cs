<<<<<<< HEAD
﻿using System;

public interface IBAseRepository
	{
	void Add();
	{
	}
}
=======
﻿using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, Tid>
        where TEntity : BaseEntity<Tid>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(Tid Id);
    }
}
>>>>>>> 7f23c34e3acad388e2d85cfe5ca01dad80125a04
