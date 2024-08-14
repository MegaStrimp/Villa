using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class BannerManager : IBannerService
    {
        private readonly IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public async Task<int> TCountAsync()
        {
            return await _bannerDal.CountAsync();
        }

        public async Task TCreateAsync(Banner entity)
        {
            await _bannerDal.CreateAsync(entity);
        }

        public async Task TDeleteAsync(ObjectId id)
        {
            await _bannerDal.DeleteAsync(id);
        }

        public async Task<Banner> TGetByIdAsync(ObjectId id)
        {
            return await _bannerDal.GetByIdAsync(id);
        }

        public async Task<List<Banner>> TGetFilteredListAsync(Expression<Func<Banner, bool>> predicate)
        {
            return await _bannerDal.GetFilteredListAsync(predicate);
        }

        public async Task<List<Banner>> TGetListAsync()
        {
            return await _bannerDal.GetListAsync();
        }

        public async Task TUpdateAsync(Banner entity)
        {
            await _bannerDal.UpdateAsync(entity);
        }
    }
}
