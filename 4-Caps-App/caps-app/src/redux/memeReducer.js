import { FETCH_DATA } from "./actionType";
const initialState = {
    items: [],
};
export const memeReducer = (state = initialState, action) => {
    switch (action.type) {
        case FETCH_DATA:
            return {
                ...state,
                items: action.payload,
            };
        default:
            return state;
    }
};
