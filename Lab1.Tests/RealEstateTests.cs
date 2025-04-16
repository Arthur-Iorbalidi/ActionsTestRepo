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
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректная площадь.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное количество комнат.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
        {
            int area = 50;
            int rooms = 2;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный этаж.", exception.Message);
        }

        [Theory]
        [InlineData("офис")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный тип недвижимости.", exception.Message);
        }

        [Theory]
        [InlineData("старое")]
        [InlineData("")]
        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное состояние объекта.", exception.Message);
        }

        [Theory]
        [InlineData("лес")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное расположение.", exception.Message);
        }


        [Theory]
        [InlineData(50, 1, 1, "квартира", "новое", "центр", 1763437.500)]
        [InlineData(50, 4, 6, "дом", "хорошее", "пригород", 2530000)]
        [InlineData(50, 3, 5, "студия", "требует ремонта", "отдаленный район", 50 * 25000 * 0.80)]
        [InlineData(100, 5, 7, "квартира", "новое", "центр", 5218125)]
		[InlineData(50, 1, 3, "квартира", "хорошее", "центр", 1781250)]
		[InlineData(50, 4, 3, "квартира", "хорошее", "центр", 2062500)]
		[InlineData(50, 2, 1, "квартира", "хорошее", "центр", 1687500)]
		[InlineData(50, 2, 6, "квартира", "хорошее", "центр", 2156250)]
		[InlineData(50, 2, 3, "квартира", "новое", "центр", 2062500)]
		[InlineData(50, 2, 3, "квартира", "требует ремонта", "центр", 1500000)]
		public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
        {
            var sut = new RealEstate(area, rooms, floor, propertyType, condition, location);

            decimal price = sut.CalculatePrice();

            Assert.Equal(expectedPrice, price);
        }
    }
}