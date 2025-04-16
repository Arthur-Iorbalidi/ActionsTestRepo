namespace Lab1.Tests
{
    public class RealEstateTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidArea_ThrowsArgumentException(int area)
        {
            int rooms = 2;
            int floor = 1;
            string propertyType = "��������";
            string condition = "�����";
            string location = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect area", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "��������";
            string condition = "�����";
            string location = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect rooms count", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
        {
            int area = 50;
            int rooms = 2;
            string propertyType = "��������";
            string condition = "�����";
            string location = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect floor", exception.Message);
        }

        [Theory]
        [InlineData("����")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "�����";
            string location = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect apartment type", exception.Message);
        }

        [Theory]
        [InlineData("������")]
        [InlineData("")]
        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "��������";
            string location = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect object state", exception.Message);
        }

        [Theory]
        [InlineData("���")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "��������";
            string condition = "�����";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Incorrect location", exception.Message);
        }


        [Theory]
        [InlineData(50, 1, 1, "��������", "�����", "�����", 1763437.500)]
        [InlineData(50, 4, 6, "���", "�������", "��������", 2530000)]
        [InlineData(50, 3, 5, "������", "������� �������", "���������� �����", 50 * 25000 * 0.80)]
        [InlineData(100, 5, 7, "��������", "�����", "�����", 5218125)]
		[InlineData(50, 1, 3, "��������", "�������", "�����", 1781250)]
		[InlineData(50, 4, 3, "��������", "�������", "�����", 2062500)]
		[InlineData(50, 2, 1, "��������", "�������", "�����", 1687500)]
		[InlineData(50, 2, 6, "��������", "�������", "�����", 2156250)]
		[InlineData(50, 2, 3, "��������", "�����", "�����", 2062500)]
		[InlineData(50, 2, 3, "��������", "������� �������", "�����", 1500000)]
		public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
        {
            var sut = new RealEstate(area, rooms, floor, propertyType, condition, location);

            decimal price = sut.CalculatePrice();

            Assert.Equal(expectedPrice, price);
        }
    }
}