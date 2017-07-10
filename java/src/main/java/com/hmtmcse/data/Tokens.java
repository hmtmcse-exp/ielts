package com.hmtmcse.data;


import org.codehaus.jackson.annotate.JsonProperty;

/**
 * Created by hmtmc on 03/07/2017.
 */
public class Tokens {

    private String token;
    private String type;

    @JsonProperty("start_offset")
    private Integer startOffset;

    @JsonProperty("end_offset")
    private Integer endOffset;

    private Integer position;

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public Integer getStartOffset() {
        return startOffset;
    }

    public void setStartOffset(Integer startOffset) {
        this.startOffset = startOffset;
    }

    public Integer getEndtOffset() {
        return endOffset;
    }

    public void setEndtOffset(Integer endtOffset) {
        this.endOffset = endtOffset;
    }

    public Integer getPosition() {
        return position;
    }

    public void setPosition(Integer position) {
        this.position = position;
    }
}
