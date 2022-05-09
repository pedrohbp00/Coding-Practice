//Empty glass verifier using Java and ImageJ

import ij.ImagePlus;
import ij.gui.HistogramWindow;
import ij.gui.NewImage;
import ij.plugin.filter.GaussianBlur;
import ij.process.FloatProcessor;
import ij.process.ImageConverter;
import ij.process.ImageProcessor;
import javax.swing.JOptionPane;

public class verifier {

    public static void main(String[] args) {
        ImagePlus img = ij.IJ.openImage();

        ImageConverter i8bits = new ImageConverter(img);
        i8bits.convertToGray8();
        img.updateAndDraw();
        ImageProcessor ip = img.getProcessor();
        //media
        ip.medianFilter();

        //automatic segmentation
        ip.autoThreshold();
        ip.invert();
        //mediana
        for (int i = 0; i < 55; i++) {
            ip.smooth();
        }

        //automatic segmentation
        ip.autoThreshold();

        ip.erode();

        double white_pixels = 0.0;

        for (int i = 0; i < ip.getWidth(); i++) {
            for (int j = 0; j < ip.getHeight(); j++) {
                int pixel = ip.getPixel(i, j);
                if (pixel == 255) {
                    white_pixels++;

                }
            }
        }
        double tamanho = ip.getWidth() * ip.getHeight();
        double media = white_pixels / tamanho;

        if (media > 0.15) {
            JOptionPane.showMessageDialog(null, "Glass is Full");
        } else {
            JOptionPane.showMessageDialog(null, "Glass is Empty");
        }
        System.out.println("White pixels: " + white_pixels);
        img.show();
        histograma(img);
    }

    public static void histograma(ImagePlus img) {

        HistogramWindow h = new HistogramWindow(img);
        ImagePlus hist = new ImagePlus("Histograma", ij.IJ.getImage().getProcessor());
        hist.show();

    }
}
