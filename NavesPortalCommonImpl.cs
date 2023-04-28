using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using NavesPortalforWebWithCoreMvc.Data;
using NavesPortalforWebWithCoreMvc.Models;
using NavesPortalforWebWithCoreMvc.ViewModels;


namespace NavesPortalforWebWithCoreMvc.Common
{
    public interface INavesPortalCommonService
    {
        List<TNAV_COMMON_CODE> GetCommonCodeList(string _groupName);

        List<NsnSelectViewModel> GetNsnSearchList();
        //Task<List<TNAV_COMMON_LOG>> getCommonLogListAsync(Guid TargetIdx);

        Task<List<TNAV_COMMON_LOG>> getCommonLogWithPlatformListAsync(Guid TargetIdx, string Platform);

        /// <summary>
        /// Work Category Code List
        /// </summary>
        /// <returns></returns>
        List<WorkCategoryViewModel> getWorkCategoryCodeListAsync();
    }

    public class NavesPortalCommonImpl : INavesPortalCommonService
    {
        private readonly BM_NAVES_PortalContext _repository;

        public NavesPortalCommonImpl(BM_NAVES_PortalContext repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 공통 코드 테이블에서 코드 값 가져오기
        /// </summary>
        /// <param name="_groupName"></param>
        /// <returns></returns>
        /// 
        public List<TNAV_COMMON_CODE> GetCommonCodeList(string _groupName)
        {
            var commonCodes = _repository.TNAV_COMMON_CODEs.Where(m => m.GROUP_NAME == _groupName).OrderBy(m => m.GROUP_ORDER).ToList();
            return commonCodes;
        }

        /// <summary>
        /// NSN ID를 이용한 검색하여 선택하기
        /// </summary>
        /// <returns></returns>
        public List<NsnSelectViewModel> GetNsnSearchList()
        {
            var nsnList = _repository.TNAV_NSN_MANAGEMENTs.ToList().OrderByDescending(m => m.REG_DATE);

            List<NsnSelectViewModel> nsnSelectViews = new List<NsnSelectViewModel>();

            foreach (TNAV_NSN_MANAGEMENT item in nsnList)
            {
                nsnSelectViews.Add(new NsnSelectViewModel
                {
                    NSN_ID = item.NSN_ID,
                    VESSEL_NAME = item.VESSEL_NAME_KR,
                    HULL_NO = item.HULL_NO,
                    YARD_MAKER = item.YARD_MAKER_NAME
                });
            }

            return nsnSelectViews;
        }

        /// <summary>
        /// 각 플랫폼의 Log 목록
        /// </summary>
        /// <param name="targetIdx">대상이 되는 IDX</param>
        /// <returns></returns>       

        public async Task<List<TNAV_COMMON_LOG>> getCommonLogWithPlatformListAsync(Guid TargetIdx, string Platform)
        {
            return await _repository.TNAV_COMMON_LOGs.Where(m => m.TARGET_IDX == TargetIdx && m.PLATFORM == Platform).OrderByDescending(m => m.REG_DATE).ToListAsync();
        }

        /// <summary>
        /// Work Category Code List
        /// </summary>
        /// <returns></returns>
        public List<WorkCategoryViewModel> getWorkCategoryCodeListAsync()
        {
            return  _repository.VNAV_SELECT_PMS_WORK_CATEGORY_CODE_LISTs.AsNoTracking().Select(m => new WorkCategoryViewModel
            {
                Category = m.CATEGORY,
                Text = m.TEXT,
                Value = m.VALUE
            }).OrderBy(m => m.Value).ToList();
        }
    }




    /// <summary>
    /// 
    /// </summary>
    public class dropdownViewModel
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Castcading { get; set; }
    }
}
