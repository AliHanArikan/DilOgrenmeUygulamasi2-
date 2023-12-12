namespace EntityLayer.Exceptions
{
    public sealed class SpanishStoryDetailsNotFound : NotFoundException {

        public SpanishStoryDetailsNotFound(int id) : base($"The Spanish story id: {id} could not dound")
        {
                
        }
    }

}
