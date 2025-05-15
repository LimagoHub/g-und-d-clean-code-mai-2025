package de.limago;

import java.awt.*;
import java.awt.event.*;


public class Fenster extends Frame  {


    public Fenster()  {

        setSize(300, 300);
        //Button button = new Button("Drück mich");
        //button.addActionListener(e-> ausgabe());
        //add(button);
        addWindowListener(new MyWindowListener());
    }


    @Override
    public void paint(final Graphics g) {
        g.drawString("Hallo", 100, 100);
    }

    public static void main(String[] args) {
        new Fenster().setVisible(true);
    }

    private void ausgabe() {
        System.out.println("Button wurde gedrückt");
    }

    private void beenden() {
        dispose();
    }


   /* private class MyActionListerner implements ActionListener {
        @Override
        public void actionPerformed(final ActionEvent e) {
            ausgabe();
        }



    }
*/
    private class MyWindowListener extends WindowAdapter {
        @Override
        public void windowClosing(WindowEvent e) {
            beenden();
        }
    }
}
