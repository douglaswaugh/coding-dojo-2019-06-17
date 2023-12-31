using System;
using System.Collections.Generic;
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

            var emptyRow = new int[8] { 0,0,0,0,0,0,0,0 };

            Assert.That(board.Row1, Is.EqualTo(emptyRow));
            Assert.That(board.Row2, Is.EqualTo(emptyRow));
            Assert.That(board.Row3, Is.EqualTo(emptyRow));
            Assert.That(board.Row4, Is.EqualTo(new int[8] { 0,0,0,1,2,0,0,0 }));
            Assert.That(board.Row5, Is.EqualTo(new int[8] { 0,0,0,2,1,0,0,0 }));
            Assert.That(board.Row6, Is.EqualTo(emptyRow));
            Assert.That(board.Row7, Is.EqualTo(emptyRow));
            Assert.That(board.Row8, Is.EqualTo(emptyRow));
        }

        [Test]
        public void New_game_first_turn_should_be_white()
        {
            var game = new Game();

            Assert.That(game.Turn, Is.EqualTo(1));
        }

        [Test]
        public void Find_opponents_first_piece_in_row()
        {
            var game = new Game();

            var row = new int[1] { 2 };

            Assert.That(game.OpponentsFirstPiece(row), Is.EqualTo(1));
        }

        [Test]
        public void Find_opponents_first_piece_in_row_of_multiple_pieces()
        {
            var game = new Game();

            var row = new int[2] { 1, 2 };

            Assert.That(game.OpponentsFirstPiece(row), Is.EqualTo(2));
        }
    }
}