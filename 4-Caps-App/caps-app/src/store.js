import { createStore } from "redux";
import addReduces from "./reducer";

const store = createStore(addReduces);
export default store;
