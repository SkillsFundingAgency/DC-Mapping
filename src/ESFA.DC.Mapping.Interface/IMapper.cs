namespace ESFA.DC.Mapping.Interface
{
    public interface IMapper<TIn, TOut>
    {
        TOut MapTo(TIn value);

        TIn MapFrom(TOut value);
    }
}
