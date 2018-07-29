using BatchGuy.App.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace BatchGuy.Unit.Tests
{
    [TestFixture]
    public class PadNumberWithZerosTests
    {
        [Test]
        public void can_pad_number_with_batch_count_less_than_ten_test()
        {
            int batchCount, fileNumber;
            //given a batch count less than ten
            batchCount = 9;
            fileNumber = 7;
            //when I get the padded number
            string paddedNumber = HelperFunctions.PadNumberWithZeros(batchCount, fileNumber);
            //then the padded number is correct
            paddedNumber.Should().Be("07");
        }

        [Test]
        public void can_pad_number_with_batch_count_greater_than_ten_and_file_number_single_digit_test()
        {
            int batchCount, fileNumber;
            //given a batch count greater than ten and file number in sigle digit
            batchCount = 22;
            fileNumber = 9;
            //when I get the padded number
            string paddedNumber = HelperFunctions.PadNumberWithZeros(batchCount, fileNumber);
            //then the padded number is correct
            paddedNumber.Should().Be("09");
        }

        [Test]
        public void can_pad_number_with_batch_count_greater_than_ten_and_file_number_double_digit_test()
        {
            int batchCount, fileNumber;
            //given a batch count greater than ten and file number in double digit
            batchCount = 22;
            fileNumber = 21;
            //when I get the padded number
            string paddedNumber = HelperFunctions.PadNumberWithZeros(batchCount, fileNumber);
            //then the padded number is correct
            paddedNumber.Should().Be("21");
        }
    }
}
