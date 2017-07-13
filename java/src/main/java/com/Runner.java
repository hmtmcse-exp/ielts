package com;

import com.hmtmcse.common.Log;
import com.hmtmcse.text.TextFileData;
import com.hmtmcse.text.TextFileReaderWriter;

import java.io.File;

/**
 * Created by touhid on 13-Jul-17.
 */
public class Runner {

    public static void main(String[] args) {

        TextFileReaderWriter textFileReaderWriter = new TextFileReaderWriter();
        for (File file : new File("store/html").listFiles()) {
            if (file.isFile()) {
                String location = "store/html/" + file.getName();
                Log.info(location);
                TextFileData textFileData = textFileReaderWriter.fileToString(location);
                String content = TextFileReaderWriter.removeSpecialCharacter(textFileData.getText());
                TextFileReaderWriter.writeToFile(content,location);
            }
        }

    }
}
