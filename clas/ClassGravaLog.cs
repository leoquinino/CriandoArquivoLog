using System;
using System.IO;
using System.Text;
using System.Net;

public class GravaLog
{     
    public void grava(string Mensagem, string path_log)
    {
        String data = DateTime.Now.ToString("yyyy-MM-dd");
        String hora = DateTime.Now.ToString("hh");
        String minutos = DateTime.Now.ToString("mm");
        String segundos = DateTime.Now.ToString("ss");
        String computador = Dns.GetHostName();
        String nomeLog = path_log + data + ".log";

        if (!Directory.Exists(path_log))
        {
            Directory.CreateDirectory(path_log);
        }

        if (Directory.Exists(path_log))
        {
            using (StreamWriter outputFile = new StreamWriter(nomeLog, true))
            {
                outputFile.WriteLine(data + " " + hora +":"+ minutos +":"+ segundos + " (" + computador + ")" + Environment.NewLine + Mensagem);
            }
        }
    }
}

