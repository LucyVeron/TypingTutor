using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public partial class KeyBoard : Form
    {
        private Button W;
        private Button R;
        private Button E;
        private Button Y;
        private Button T;
        private TextBox Output;
        private Button P;
        private Button O;
        private Button I;
        private Button U;
        private Button L;
        private Button K;
        private Button J;
        private Button H;
        private Button G;
        private Button F;
        private Button D;
        private Button S;
        private Button A;
        private Button M;
        private Button N;
        private Button B;
        private Button V;
        private Button C;
        private Button X;
        private Button Z;
        private Button Num1;
        private Button Num2;
        private Button Num0;
        private Button Num9;
        private Button Num8;
        private Button Num7;
        private Button Num6;
        private Button Num5;
        private Button Num4;
        private Button Num3;
        private Button Quotes;
        private Button Colons;
        private Button Plus;
        private Button Minus;
        private Button Tilde;
        private Button Question;
        private Button Period;
        private Button Comma;
        private Button Pipe;
        private Button RightBracket;
        private Button LeftBracket;
        private Button Backspace;
        private Button CapsLock;
        private Button LeftShift;
        private Button Space;
        private Button Q;

        public KeyBoard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Q = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Quotes = new System.Windows.Forms.Button();
            this.Colons = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Tilde = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Pipe = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.CapsLock = new System.Windows.Forms.Button();
            this.LeftShift = new System.Windows.Forms.Button();
            this.Space = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Q
            // 
            this.Q.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(54, 146);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(80, 66);
            this.Q.TabIndex = 0;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            // 
            // W
            // 
            this.W.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.Location = new System.Drawing.Point(140, 146);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(80, 66);
            this.W.TabIndex = 1;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            // 
            // R
            // 
            this.R.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(312, 146);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(80, 66);
            this.R.TabIndex = 3;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(226, 146);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(80, 66);
            this.E.TabIndex = 2;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            // 
            // Y
            // 
            this.Y.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.Location = new System.Drawing.Point(484, 146);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(80, 66);
            this.Y.TabIndex = 5;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            // 
            // T
            // 
            this.T.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(398, 146);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(80, 66);
            this.T.TabIndex = 4;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(54, 25);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(1225, 34);
            this.Output.TabIndex = 6;
            // 
            // P
            // 
            this.P.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(828, 146);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(80, 66);
            this.P.TabIndex = 10;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            // 
            // O
            // 
            this.O.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(742, 146);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(80, 66);
            this.O.TabIndex = 9;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            // 
            // I
            // 
            this.I.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(656, 146);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(80, 66);
            this.I.TabIndex = 8;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            // 
            // U
            // 
            this.U.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U.Location = new System.Drawing.Point(570, 146);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(80, 66);
            this.U.TabIndex = 7;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            // 
            // L
            // 
            this.L.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.Location = new System.Drawing.Point(943, 218);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(80, 66);
            this.L.TabIndex = 19;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            // 
            // K
            // 
            this.K.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K.Location = new System.Drawing.Point(857, 218);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(80, 66);
            this.K.TabIndex = 18;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            // 
            // J
            // 
            this.J.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J.Location = new System.Drawing.Point(771, 218);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(80, 66);
            this.J.TabIndex = 17;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(685, 218);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(80, 66);
            this.H.TabIndex = 16;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(599, 218);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(80, 66);
            this.G.TabIndex = 15;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(513, 218);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(80, 66);
            this.F.TabIndex = 14;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(427, 218);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(80, 66);
            this.D.TabIndex = 13;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(341, 218);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(80, 66);
            this.S.TabIndex = 12;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(255, 218);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(80, 66);
            this.A.TabIndex = 11;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(771, 290);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(80, 66);
            this.M.TabIndex = 26;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(685, 290);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(80, 66);
            this.N.TabIndex = 25;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(599, 290);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(80, 66);
            this.B.TabIndex = 24;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // V
            // 
            this.V.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(513, 290);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(80, 66);
            this.V.TabIndex = 23;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(427, 290);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(80, 66);
            this.C.TabIndex = 22;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(341, 290);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(80, 66);
            this.X.TabIndex = 21;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            // 
            // Z
            // 
            this.Z.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z.Location = new System.Drawing.Point(255, 290);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(80, 66);
            this.Z.TabIndex = 20;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(140, 74);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(80, 66);
            this.Num1.TabIndex = 27;
            this.Num1.Text = "!\r\n1";
            this.Num1.UseVisualStyleBackColor = true;
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(226, 74);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(80, 66);
            this.Num2.TabIndex = 28;
            this.Num2.Text = "@\r\n2";
            this.Num2.UseVisualStyleBackColor = true;
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(914, 74);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(80, 66);
            this.Num0.TabIndex = 36;
            this.Num0.Text = ")\r\n0";
            this.Num0.UseVisualStyleBackColor = true;
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(828, 74);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(80, 66);
            this.Num9.TabIndex = 35;
            this.Num9.Text = "(\r\n9";
            this.Num9.UseVisualStyleBackColor = true;
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(742, 74);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(80, 66);
            this.Num8.TabIndex = 34;
            this.Num8.Text = "*\r\n8";
            this.Num8.UseVisualStyleBackColor = true;
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(656, 74);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(80, 66);
            this.Num7.TabIndex = 33;
            this.Num7.Text = "&&\r\n7";
            this.Num7.UseVisualStyleBackColor = true;
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(570, 74);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(80, 66);
            this.Num6.TabIndex = 32;
            this.Num6.Text = "^\r\n6";
            this.Num6.UseVisualStyleBackColor = true;
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(484, 74);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(80, 66);
            this.Num5.TabIndex = 31;
            this.Num5.Text = "%\r\n5";
            this.Num5.UseVisualStyleBackColor = true;
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(398, 74);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(80, 66);
            this.Num4.TabIndex = 30;
            this.Num4.Text = "$\r\n4";
            this.Num4.UseVisualStyleBackColor = true;
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(312, 74);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(80, 66);
            this.Num3.TabIndex = 29;
            this.Num3.Text = "#\r\n3";
            this.Num3.UseVisualStyleBackColor = true;
            // 
            // Quotes
            // 
            this.Quotes.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quotes.Location = new System.Drawing.Point(1115, 218);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(164, 66);
            this.Quotes.TabIndex = 39;
            this.Quotes.Text = "\"\r\n\'";
            this.Quotes.UseVisualStyleBackColor = true;
            // 
            // Colons
            // 
            this.Colons.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colons.Location = new System.Drawing.Point(1029, 218);
            this.Colons.Name = "Colons";
            this.Colons.Size = new System.Drawing.Size(80, 66);
            this.Colons.TabIndex = 40;
            this.Colons.Text = ":\r\n;";
            this.Colons.UseVisualStyleBackColor = true;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(1086, 74);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(80, 66);
            this.Plus.TabIndex = 41;
            this.Plus.Text = "+\r\n=";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(1000, 74);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(80, 66);
            this.Minus.TabIndex = 42;
            this.Minus.Text = "_\r\n-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // Tilde
            // 
            this.Tilde.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tilde.Location = new System.Drawing.Point(54, 74);
            this.Tilde.Name = "Tilde";
            this.Tilde.Size = new System.Drawing.Size(80, 66);
            this.Tilde.TabIndex = 43;
            this.Tilde.Text = "~\r\n`";
            this.Tilde.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(1029, 290);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(250, 66);
            this.Question.TabIndex = 46;
            this.Question.Text = "?\r\n/";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // Period
            // 
            this.Period.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period.Location = new System.Drawing.Point(943, 290);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(80, 66);
            this.Period.TabIndex = 45;
            this.Period.Text = ">\r\n.";
            this.Period.UseVisualStyleBackColor = true;
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comma.Location = new System.Drawing.Point(857, 290);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(80, 66);
            this.Comma.TabIndex = 44;
            this.Comma.Text = "<\r\n,";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // Pipe
            // 
            this.Pipe.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pipe.Location = new System.Drawing.Point(1086, 146);
            this.Pipe.Name = "Pipe";
            this.Pipe.Size = new System.Drawing.Size(193, 66);
            this.Pipe.TabIndex = 49;
            this.Pipe.Text = "|\r\n\\";
            this.Pipe.UseVisualStyleBackColor = true;
            // 
            // RightBracket
            // 
            this.RightBracket.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightBracket.Location = new System.Drawing.Point(1000, 146);
            this.RightBracket.Name = "RightBracket";
            this.RightBracket.Size = new System.Drawing.Size(80, 66);
            this.RightBracket.TabIndex = 48;
            this.RightBracket.Text = "}\r\n]";
            this.RightBracket.UseVisualStyleBackColor = true;
            // 
            // LeftBracket
            // 
            this.LeftBracket.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftBracket.Location = new System.Drawing.Point(914, 146);
            this.LeftBracket.Name = "LeftBracket";
            this.LeftBracket.Size = new System.Drawing.Size(80, 66);
            this.LeftBracket.TabIndex = 47;
            this.LeftBracket.Text = "{\r\n[";
            this.LeftBracket.UseVisualStyleBackColor = true;
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.Control;
            this.Backspace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Backspace.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backspace.ForeColor = System.Drawing.SystemColors.Control;
            this.Backspace.Location = new System.Drawing.Point(1172, 74);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(107, 66);
            this.Backspace.TabIndex = 50;
            this.Backspace.Text = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            // 
            // CapsLock
            // 
            this.CapsLock.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapsLock.Location = new System.Drawing.Point(54, 218);
            this.CapsLock.Name = "CapsLock";
            this.CapsLock.Size = new System.Drawing.Size(195, 66);
            this.CapsLock.TabIndex = 52;
            this.CapsLock.Text = "CapsLock";
            this.CapsLock.UseVisualStyleBackColor = true;
            // 
            // LeftShift
            // 
            this.LeftShift.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftShift.Location = new System.Drawing.Point(54, 290);
            this.LeftShift.Name = "LeftShift";
            this.LeftShift.Size = new System.Drawing.Size(195, 66);
            this.LeftShift.TabIndex = 53;
            this.LeftShift.Text = "Shift";
            this.LeftShift.UseVisualStyleBackColor = true;
            // 
            // Space
            // 
            this.Space.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Space.Location = new System.Drawing.Point(53, 362);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(1226, 66);
            this.Space.TabIndex = 55;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = true;
            // 
            // KeyBoard
            // 
            this.ClientSize = new System.Drawing.Size(1344, 451);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.LeftShift);
            this.Controls.Add(this.CapsLock);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Pipe);
            this.Controls.Add(this.RightBracket);
            this.Controls.Add(this.LeftBracket);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.Tilde);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Colons);
            this.Controls.Add(this.Quotes);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.M);
            this.Controls.Add(this.N);
            this.Controls.Add(this.B);
            this.Controls.Add(this.V);
            this.Controls.Add(this.C);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.I);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.T);
            this.Controls.Add(this.R);
            this.Controls.Add(this.E);
            this.Controls.Add(this.W);
            this.Controls.Add(this.Q);
            this.KeyPreview = true;
            this.Name = "KeyBoard";
            this.Text = "Keyboard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBoard_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBoard_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBoard_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void KeyBoard_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case (Keys.Back):
                    Backspace.BackColor = Color.Red;
                    if (Output.Text.Length > 0)
                        Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
                    e.SuppressKeyPress = true;
                    break;

                case (Keys.CapsLock): CapsLock.BackColor = Color.Red; break;
                case (Keys.ShiftKey): LeftShift.BackColor = Color.Red; break;
                case (Keys.Space): Space.BackColor = Color.Red; break;

                case (Keys.Oemtilde): Tilde.BackColor = Color.Red; break;
                case (Keys.OemSemicolon): Colons.BackColor = Color.Red; break;
                case (Keys.OemQuotes): Quotes.BackColor = Color.Red; break;
                case (Keys.OemMinus): Minus.BackColor = Color.Red; break;
                case (Keys.Oemplus): Plus.BackColor = Color.Red; break;
                case (Keys.OemPeriod): Period.BackColor = Color.Red; break;
                case (Keys.Oemcomma): Comma.BackColor = Color.Red; break;
                case (Keys.OemQuestion): Question.BackColor = Color.Red; break;
                case (Keys.OemOpenBrackets): LeftBracket.BackColor = Color.Red; break;
                case (Keys.OemCloseBrackets): RightBracket.BackColor = Color.Red; break;
                case (Keys.OemPipe): Pipe.BackColor = Color.Red; break;

                case (Keys.D1): Num1.BackColor = Color.Red; break;
                case (Keys.D2): Num2.BackColor = Color.Red; break;
                case (Keys.D3): Num3.BackColor = Color.Red; break;
                case (Keys.D4): Num4.BackColor = Color.Red; break;
                case (Keys.D5): Num5.BackColor = Color.Red; break;
                case (Keys.D6): Num6.BackColor = Color.Red; break;
                case (Keys.D7): Num7.BackColor = Color.Red; break;
                case (Keys.D8): Num8.BackColor = Color.Red; break;
                case (Keys.D9): Num9.BackColor = Color.Red; break;
                case (Keys.D0): Num0.BackColor = Color.Red; break;

                case (Keys.Q): Q.BackColor = Color.Red; break;
                case (Keys.W): W.BackColor = Color.Red; break;
                case (Keys.E): E.BackColor = Color.Red; break;
                case (Keys.R): R.BackColor = Color.Red; break;
                case (Keys.T): T.BackColor = Color.Red; break;
                case (Keys.Y): Y.BackColor = Color.Red; break;
                case (Keys.U): U.BackColor = Color.Red; break;
                case (Keys.I): I.BackColor = Color.Red; break;
                case (Keys.O): O.BackColor = Color.Red; break;
                case (Keys.P): P.BackColor = Color.Red; break;
                case (Keys.A): A.BackColor = Color.Red; break;
                case (Keys.S): S.BackColor = Color.Red; break;
                case (Keys.D): D.BackColor = Color.Red; break;
                case (Keys.F): F.BackColor = Color.Red; break;
                case (Keys.G): G.BackColor = Color.Red; break;
                case (Keys.H): H.BackColor = Color.Red; break;
                case (Keys.J): J.BackColor = Color.Red; break;
                case (Keys.K): K.BackColor = Color.Red; break;
                case (Keys.L): L.BackColor = Color.Red; break;
                case (Keys.Z): Z.BackColor = Color.Red; break;
                case (Keys.X): X.BackColor = Color.Red; break;
                case (Keys.C): C.BackColor = Color.Red; break;
                case (Keys.V): V.BackColor = Color.Red; break;
                case (Keys.B): B.BackColor = Color.Red; break;
                case (Keys.N): N.BackColor = Color.Red; break;
                case (Keys.M): M.BackColor = Color.Red; break;
            }
        }

        private void KeyBoard_KeyUp(object sender, KeyEventArgs e)
        {
            Backspace.BackColor = default(Color);
            CapsLock.BackColor = default(Color);
            LeftShift.BackColor = default(Color);
            Space.BackColor = default(Color);

            Tilde.BackColor = default(Color);
            Minus.BackColor = default(Color);
            Plus.BackColor = default(Color);
            Colons.BackColor = default(Color);
            Quotes.BackColor = default(Color);
            Comma.BackColor = default(Color);
            Period.BackColor = default(Color);
            Question.BackColor = default(Color);
            LeftBracket.BackColor = default(Color);
            RightBracket.BackColor = default(Color);
            Pipe.BackColor = default(Color);

            Num1.BackColor = default(Color);
            Num2.BackColor = default(Color);
            Num3.BackColor = default(Color);
            Num4.BackColor = default(Color);
            Num5.BackColor = default(Color);
            Num6.BackColor = default(Color);
            Num7.BackColor = default(Color);
            Num8.BackColor = default(Color);
            Num9.BackColor = default(Color);
            Num0.BackColor = default(Color);

            Q.BackColor = default(Color);
            W.BackColor = default(Color);
            E.BackColor = default(Color);
            R.BackColor = default(Color);
            T.BackColor = default(Color);
            Y.BackColor = default(Color);
            U.BackColor = default(Color);
            I.BackColor = default(Color);
            O.BackColor = default(Color);
            P.BackColor = default(Color);
            A.BackColor = default(Color);
            S.BackColor = default(Color);
            D.BackColor = default(Color);
            F.BackColor = default(Color);
            G.BackColor = default(Color);
            H.BackColor = default(Color);
            J.BackColor = default(Color);
            K.BackColor = default(Color);
            L.BackColor = default(Color);
            Z.BackColor = default(Color);
            X.BackColor = default(Color);
            C.BackColor = default(Color);
            V.BackColor = default(Color);
            B.BackColor = default(Color);
            N.BackColor = default(Color);
            M.BackColor = default(Color);
        }

        private void KeyBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            Output.Text += e.KeyChar;
        }
    }
}
