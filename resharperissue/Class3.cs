using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
// ReSharper disable InconsistentNaming

namespace resharperissue
{
    [Subject("3")]
    public class Class3 : Observes
    {
        private static int sut;

        private Establish that = () =>
            sut = 10;

        private It should_equal_10 = () => sut.ShouldEqual(10);
        private It should_not_equal_11 = () => sut.ShouldNotEqual(11);
        private It should_not_equal_12 = () => sut.ShouldNotEqual(12);
    }
}
