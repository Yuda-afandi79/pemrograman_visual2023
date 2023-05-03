from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("390x420")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10, background="#5F9EA0")
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='masukan panjang diagonal 1:',border=0, width=30, font=30, background="#5F9EA0").grid(row=1, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="masukan panjang diagonal 2:", border=0, width=30, font=30, background="#5F9EA0").grid(row=3, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="masukan sisi:", border=0, width=30, font=30, background="#5F9EA0").grid(row=5, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="Luas bela ketupat adalah:", border=0, width=30, font=30, background="#5F9EA0").grid(row=8, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="keliling bela ketupat adalah:", border=0, width=30, font=30, background="#5F9EA0").grid(row=11, column=0, sticky=W, padx=20, pady=5)


        # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame, border=0, width=30, font=30)
        self.txtdiagonal1.grid(row=2, column=0, padx=20, pady=5) 
        self.txtdiagonal2 = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtdiagonal2.grid(row=4, column=0, padx=20, pady=5) 
        self.txtsisi = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtsisi.grid(row=6, column=0, padx=20, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=9, column=0, padx=20, pady=5)  
        self.txtkeliling = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtkeliling.grid(row=12, column=0, padx=20, pady=5)   
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#FFACAC")
        self.btnHitung.grid(row=7, column=0, padx=20, pady=5)
    
    # fungsi untuk menghitung luas bela ketupat
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        diagonal1 = int(self.txtdiagonal1.get())
        diagonal2 = int(self.txtdiagonal2.get())
        s = int(self.txtsisi.get())

        bela_ketupat = LuaskelilingDiagonal(diagonal1, diagonal2, s)
        luas = bela_ketupat.luas()
        keliling = bela_ketupat.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))

        self.txtkeliling.delete(0, END)
        self.txtkeliling.insert(END, str(keliling))
        
    
class LuaskelilingDiagonal:
    def __init__(self, diagonal1, diagonal2, sisi):
        self.diagonal1 = diagonal1
        self.diagonal2 = diagonal2
        self.sisi = sisi

    def luas(self):
        return 0.5 * (self.diagonal1 * self.diagonal2)
    
    def keliling(self):
        return 2 * self.sisi
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas Bela ketupat")
    root.mainloop()
    