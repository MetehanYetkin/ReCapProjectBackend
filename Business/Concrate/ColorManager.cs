using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ColorManager : IColorService

    {
        IColorDal _colorDal;
        public ColorManager(IColorDal ıcolorDal)
        {
            _colorDal = ıcolorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.AddingSuccessful);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.DeletingSuccessful);
        }

        public IDataResult<List<Color>> GetAll()
        {

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<List<Color>> GetColorById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.UpdatingSuccessful);
        }
    }
}
