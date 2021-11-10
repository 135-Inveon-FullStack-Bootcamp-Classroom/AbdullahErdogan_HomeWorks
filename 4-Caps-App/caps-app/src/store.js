import { configureStore } from "@reduxjs/toolkit";
import memeReducer from "./redux/memeReducer";

const Store = configureStore({
    reducer: {
        memes: memeReducer,
    },
});

export default Store;
