package com.hmtmcse.common;

/**
 * Created by touhid on 13/12/2015.
 */
public class AppExceptionHandler extends Exception {

    public AppExceptionHandler(){
        super("Unknown Exception");
    }

    public AppExceptionHandler(String message){
        super(message);
    }

}
