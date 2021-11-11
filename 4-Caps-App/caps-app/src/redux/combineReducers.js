import { combineReducers } from "redux";
import { memeReducer } from "./memeReducer";
const reducers = combineReducers({
    allMemes: memeReducer,
});
export default reducers;
