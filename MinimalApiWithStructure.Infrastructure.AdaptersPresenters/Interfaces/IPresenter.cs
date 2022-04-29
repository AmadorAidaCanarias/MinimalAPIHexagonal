namespace MinimalApiWithStructure.Infrastructure.AdaptersPresenters.Interfaces
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
