using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class TVector2D
    {
        private double a1_;
        private double a2_;

        public double a1
        {
            get { return a1_; }
            set { a1_= value; }
        }
        public double a2
        {
            get { return a2_; }
            set { a2_ = value; }
        }
        public TVector2D()
        {
            Random ran = new Random();
            this.a1_ = ran.Next(1, 50);
            this.a2_ = ran.Next(1, 50);
        }
        public TVector2D(double A1, double A2)
        {
                this.a1_ = A1;
            this.a2_ = A2;
            
        }
        public TVector2D(TVector2D ve)
        {
            this.a1_ = ve.a1_;
            this.a2_ = ve.a2_;
        }
        override public string ToString()
        {
            return "Новий вектор ("+a1_+";"+a2_;
        }
        public void ChangeElements(double A1, double A2)
        {
            this.a1_ = A1;
            this.a2_ = A2;
        }
        public double VectorLength()
        {
            return Math.Sqrt(Math.Pow(a1_, 2) + Math.Pow(a2_, 2));
        }
        public TVector2D ToNormVector()
        {
            TVector2D normVector = new TVector2D(a1_ / VectorLength(), a2_ / VectorLength());
            return normVector;
        }
        public bool IsTheSame(TVector2D b)
        {
            bool res = false;
            if (this.a1_ == b.a1_&& this.a2_ == b.a2_) res = true;
            return res;
        }
        public static TVector2D operator +(TVector2D a, TVector2D b)
        {
            TVector2D vector = new TVector2D(a.a1_ + b.a1_, a.a2_ + b.a2_);
            return vector;
        }
        public static TVector2D operator -(TVector2D a, TVector2D b)
        {
            TVector2D vector = new TVector2D(a.a1_ - b.a1_, a.a2_ - b.a2_);
            return vector;
        }
        public static TVector2D operator *(TVector2D a, TVector2D b)
        {
            TVector2D vector = new TVector2D(a.a1_ * b.a1_, a.a2_ * b.a2_);
            return vector;
        }


    }
}