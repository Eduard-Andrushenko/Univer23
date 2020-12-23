string text = textBox1.Text;
char[] obrtext = text.ToCharArray();
if(text==finaltext)
            {
                MessageBox.Show("Данная запись является палиндромом");
            }
            if (text!=finaltext)
            {
                MessageBox.Show("Данная запись не является палиндромом");
            }