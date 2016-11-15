package cviz.timeline.commands;

import cviz.ITimeline;

public abstract class ICommand {
    private final int layerId;

    protected ICommand(int layerId){
        this.layerId = layerId;
    }

    public int getLayerId(){
        return layerId;
    }

    public abstract boolean execute(ITimeline timeline);

    public String[] getTemplateFields() {
        return new String[0];
    }


    public abstract String toString();
}
