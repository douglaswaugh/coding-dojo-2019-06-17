using Domain;
using NUnit.Framework;

namespace Tests
{
    public class BoardTests
    {
        [Test]
        public void New_board_should_be_at_starting_position()
        {
            var board = new Board();

            Assert.That(board.Row1, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
            Assert.That(board.Row2, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
            Assert.That(board.Row3, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
            Assert.That(board.Row4, Is.EqualTo(new int[8] { 0,0,0,1,2,0,0,0 }));
            Assert.That(board.Row5, Is.EqualTo(new int[8] { 0,0,0,2,1,0,0,0 }));
            Assert.That(board.Row6, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
            Assert.That(board.Row7, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
            Assert.That(board.Row8, Is.EqualTo(new int[8] { 0,0,0,0,0,0,0,0 }));
        }
    }
}