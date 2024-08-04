import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;

public class Main {
    public static void main(String[] args) {

        // DocumentBuilder : "Defines a factory API that enables applications to obtain
        // a parser that produces DOM object trees from XML documents."
        DocumentBuilderFactory factory =
                DocumentBuilderFactory.newInstance();

        try {
            // The file we will load
            File inputFile = new File("inventory.xml");
            // We should create a documentum that represents the XML file
            DocumentBuilderFactory documentBuilderFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder documentBuilder = documentBuilderFactory.newDocumentBuilder();
            Document doc = documentBuilder.parse(inputFile);
            doc.getDocumentElement().normalize();

            // Get the root element
            String rootElement = doc.getDocumentElement().getNodeName();
            System.out.println("The root element is: " + rootElement);

            // Information about the XML file
            System.out.println("XML version: "+doc.getXmlVersion());
            System.out.println("XML encoding: "+doc.getXmlEncoding());
            System.out.println("URI: "+doc.getDocumentURI());

            // NodeList is an ordered collection of nodes - collect all product elements
            NodeList nodeList = doc.getElementsByTagName("product");

            for (int index = 0; index < nodeList.getLength(); index++) {
                Node node = nodeList.item(index);

                // We can retrieve information about the node
                System.out.println("\nElement name: " + node.getNodeName());

                // We are interested in elements
                if (node.getNodeType() == Node.ELEMENT_NODE) {
                    Element element = (Element) node;

                    System.out.println("  Product id: "
                            + element.getAttribute("id"));

                    System.out.println("  Product name: "
                            + element
                            .getElementsByTagName("name")
                            .item(0)
                            .getTextContent());

                    System.out.println("  Product type: "
                            + element
                            .getElementsByTagName("type")
                            .item(0)
                            .getTextContent());

                    System.out.println("  Quantity: "
                            + element
                            .getElementsByTagName("quantity")
                            .item(0)
                            .getTextContent());
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}