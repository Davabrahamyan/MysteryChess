using Service.Models;

namespace Impl;

public sealed class MysteryChessService 
{
    public static async Task MovePiece(ChessPieceCoordinateModel model, int[,] chessBoard)
    {
        switch (chessBoard[model.currentPositionX, model.currentPositionY])
        {
            case (int)PiecesEnum.WhiteBishop:
                if (BasePieceMove.IsLegalBishopMove(model))
                    break;
                else
                  throw new Exception("Illegal Bishop move");
                
            case (int)PiecesEnum.WhiteKnight:
                if (BasePieceMove.IsLegalKnightMove(model))
                    break;
                else
                    throw new Exception("Illegal Knight move");

            case (int)PiecesEnum.WhiteRook:
                if (BasePieceMove.IsLegalRookMove(model))
                    break;
                else
                    throw new Exception("Illegal Knight move");

            case (int)PiecesEnum.WhiteKing:
                if (BasePieceMove.IsLegalKingMove(model))
                    break;
                else 
                    throw new Exception("Illegal King move");

            case (int)PiecesEnum.WhiteQueen:
                if (BasePieceMove.IsLegalBishopMove(model) || BasePieceMove.IsLegalRookMove(model))
                    break;
                else throw new Exception("Illegal Queen move");

            case (int)PiecesEnum.BlackBishop:
                goto case (int)PiecesEnum.WhiteBishop;

            case (int)PiecesEnum.BlackKnight:
                goto case (int)PiecesEnum.WhiteKnight;

            case (int)PiecesEnum.BlackKing:
                goto case (int)PiecesEnum.WhiteKing;

            case (int)PiecesEnum.BlackQueen:
                goto case (int)PiecesEnum.WhiteQueen;

            default:
                break;
        }

        if(chessBoard[model.currentPositionX, model.currentPositionY] == 0)
        {
            await Console.Out.WriteLineAsync("There is no piece in the current place");
        }

        if (chessBoard[model.newPositionX, model.newPositionY] == 0 || chessBoard[model.newPositionX, model.newPositionY] < 0)
        {
            chessBoard[model.newPositionX, model.newPositionY] = chessBoard[model.currentPositionX, model.currentPositionY];
            chessBoard[model.currentPositionX, model.currentPositionY] = 0;
        }

        else
        {
            await Console.Out.WriteLineAsync("There is already your piece");
        }
    }
}
