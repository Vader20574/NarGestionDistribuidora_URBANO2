
private void TabControl1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
{
    if (HabiliTabPages == false)
        return;

    if (TabControl1.SelectedIndex != 0)
    {
        if (tcodigo.Text.Trim() == "")
        {
            Interaction.MsgBox("FALTA CODIGO DE CLIENTE..", MsgBoxStyle.Exclamation, "");
            TabControl1.SelectedIndex = 0;
        }
    }
}
