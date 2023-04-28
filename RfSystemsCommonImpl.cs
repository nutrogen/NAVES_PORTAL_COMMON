using System.Collections.Generic;
using System.Linq;
using NavesPortalforWebWithCoreMvc.RfSystemModels;
using NavesPortalforWebWithCoreMvc.RfSystemData;

namespace NavesPortalforWebWithCoreMvc.Common
{
    public interface IRfSystemCommonService
    {
        List<RFV_CRM_BASIC_INFO> GetCrmBasicInfo();

        IQueryable<RFV_YARD_MAKER> GetRfvYardMaker();
    }

    public class RfSystemsCommonImpl : IRfSystemCommonService
    {
        private readonly RfSystemContext _repository;

        public RfSystemsCommonImpl(RfSystemContext repository)
        {
            _repository = repository;
        }
        public List<RFV_CRM_BASIC_INFO> GetCrmBasicInfo()
        {
            return _repository.RFV_CRM_BASIC_INFOs.ToList();
        }

        /// <summary>
        /// Yard Maker
        /// </summary>
        /// <returns></returns>
        public IQueryable<RFV_YARD_MAKER> GetRfvYardMaker()
        {
            return _repository.RFV_YARD_MAKERs.AsQueryable();
        }
                
    }


}
