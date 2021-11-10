const initialState = {
    items: [],
};
function memeReducer(state = initialState, action) {
    switch (action.type) {
        case "FETCH_DATA":
            return {
                ...state,
                items: action.items,
            };
        default:
            return state;
    }
}
export default memeReducer;
