using System;
using System.Collections.Generic;

namespace ChinaChessCheck
{
    public abstract class ChessPiece
    {
        public string Name { get; set; }
        public int Team { get; set; }
        public Position position { get; set; }

        public virtual bool CheckMove(int X,int Y)
        {
            return true;
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static class BoardGame
    {
        public static List<ChessPiece> InitBoard()
        {
            List<ChessPiece> list = new List<ChessPiece>();
            // tạo quân cờ
            #region team 1 
            Tot tot1 = new Tot { Name = "Tốt 1", Team = 1, position = new Position(0, 3) };
            //Tot tot1 = new Tot { Name = "Tốt 1", Team = 1, position = new Position(0, 5) }; //  test tot qua song
            list.Add(tot1);
            for (int i = 0; i < 4; i++)
            {
                Tot tot = new Tot { Name = "Tốt 1", Team = 1, position = new Position((i+1)* 2, 3) };
                list.Add(tot);
            }

            // pháo
            Phao phao = new Phao { Name = "Pháo 1", Team = 1, position = new Position(1,2) };
            Phao phao1 = new Phao { Name = "Pháo 1", Team = 1, position = new Position(7,2) };
            list.Add(phao);
            list.Add(phao1);

            // xe
            Xe xe = new Xe { Name = "xe 1", Team = 1, position = new Position(0, 0) };
            Xe xe1 = new Xe { Name = "xe 1", Team = 1, position = new Position(8, 0) };
            list.Add(xe);
            list.Add(xe1);

            // mã
            Ma ma = new Ma { Name = "mã 1", Team = 1, position = new Position(1, 0) };
            Ma ma1 = new Ma { Name = "mã 1", Team = 1, position = new Position(7, 0) };
            list.Add(ma);
            list.Add(ma1);

            // tượng 
            Tinh tinh = new Tinh { Name = "tượng 1", Team = 1, position = new Position(2, 0) };
            Tinh tinh1 = new Tinh { Name = "tượng 1", Team = 1, position = new Position(6, 0) };
            list.Add(tinh);
            list.Add(tinh1);

            // Sĩ 
            Si si = new Si { Name = "Sĩ 1", Team = 1, position = new Position(3, 0) };
            Si si1 = new Si { Name = "Sĩ 1", Team = 1, position = new Position(5, 0) };
            list.Add(si);
            list.Add(si1);

            Tuong tuong1 = new Tuong { Name = "Tướng 1",Team = 1,position = new Position(4, 0) };
            list.Add(tuong1);
            #endregion

            #region team 2 
            Tot tot2 = new Tot { Name = "Tốt 2", Team = 2, position = new Position(0, 6) };
            list.Add(tot2);
            for (int i = 0; i < 4; i++)
            {
                Tot tot = new Tot { Name = "Tốt 2", Team = 1, position = new Position((i + 1) * 2, 6) };
                list.Add(tot);
            }

            // pháo
            Phao phao2 = new Phao { Name = "Pháo 2", Team = 2, position = new Position(1, 7) };
            Phao phao12 = new Phao { Name = "Pháo 2", Team = 2, position = new Position(7, 7) };
            list.Add(phao2);
            list.Add(phao12);

            // xe
            Xe xe2 = new Xe { Name = "xe 2", Team = 2, position = new Position(0, 9) };
            Xe xe12 = new Xe { Name = "xe 2", Team = 2, position = new Position(8, 9) };
            list.Add(xe2);
            list.Add(xe12);

            // mã
            Ma ma2 = new Ma { Name = "mã 2", Team = 2, position = new Position(1, 9) };
            Ma ma12 = new Ma { Name = "mã 2", Team = 2, position = new Position(7,9 ) };
            list.Add(ma2);
            list.Add(ma12);

            // tượng 
            Tinh tinh2 = new Tinh { Name = "tượng 2", Team = 2, position = new Position(2, 9) };
            Tinh tinh12 = new Tinh { Name = "tượng 2", Team = 2, position = new Position(6, 9) };
            list.Add(tinh2);
            list.Add(tinh12);

            // Sĩ 
            Si si2 = new Si { Name = "Sĩ 2", Team = 2, position = new Position(3, 9) };
            Si si12 = new Si { Name = "Sĩ 2", Team = 2, position = new Position(5, 9) };
            list.Add(si2);
            list.Add(si12);

            Tuong tuong2 = new Tuong { Name = "Tướng 2", Team = 2, position = new Position(4, 9) };
            list.Add(tuong2);
            #endregion

            return list;
        }

        
    }
}
