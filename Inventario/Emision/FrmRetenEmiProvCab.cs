
protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
{
    switch (keyData)
    {
        case Keys.F3:
            {
                if (this.dgvlista.Focused == true)
                {
                    var i = this.dgvlista.RowCount;
                    if (i > 0)
                    {
                        lista.RemoveAt(dgvlista.CurrentRow.Index);
                        Calcula_Total();
                    }
                }

                break;
            }
    }
}
