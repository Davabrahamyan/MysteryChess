using Service.Abstraction;
using Service.Models;

namespace Impl;

public static class BasePieceMove 
{
    public static bool IsLegalBishopMove(ChessPieceCoordinateModel model)
    {
        if (Math.Abs(model.newPositionX - model.currentPositionX) == Math.Abs(model.newPositionY - model.currentPositionY))
        {
            return true;
        }
        else return false;
    }
    public static bool IsLegalRookMove(ChessPieceCoordinateModel model)
    {
        if (model.currentPositionX == model.newPositionX && model.currentPositionY != model.newPositionY ||
            model.currentPositionX != model.newPositionX && model.currentPositionY == model.newPositionY) 
        { 
            return true;
        }
        else return false;
    }
    public static bool IsLegalKnightMove(ChessPieceCoordinateModel model)
    {
        if (Math.Abs(model.newPositionX - model.currentPositionX) == 1 && Math.Abs(model.newPositionY - model.currentPositionY) == 2) 
        {
            return true;
        }
        else if(Math.Abs(model.newPositionX - model.currentPositionX) == 2 && Math.Abs(model.newPositionY - model.currentPositionY) == 1)
        {
            return true;
        }
        else return false;
    }

    public static bool IsLegalKingMove(ChessPieceCoordinateModel model)
    {
        if (Math.Abs(model.currentPositionX - model.newPositionX) <= 1 && Math.Abs(model.currentPositionY - model.newPositionY) <= 1) return true;

        else return false;
    }
}
